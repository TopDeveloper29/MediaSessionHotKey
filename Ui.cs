using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using WindowsMediaController;
using static WindowsMediaController.MediaManager;

namespace MediaSessionHotKey
{

    public partial class Ui : MaterialForm
    {
        private static readonly MediaManager mediaManager = new MediaManager();
        private static MediaSession currentSession = null;
        private const int WM_HOTKEY = 0x0312;
        private const string AppOnStartupKey = @"Software\MediaSessionHotKey";
        private string CurrentStartupPath = null;
        public Ui()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            mediaManager.OnAnySessionOpened += MediaManager_HandleNewSession;
            mediaManager.OnFocusedSessionChanged += MediaManager_HandleNewSession;
            mediaManager.Start();
           
            HotKeyManager.RegisterSystemHotKey(Handle, Keys.Control, Keys.D9, 19);
            HotKeyManager.RegisterSystemHotKey(Handle, Keys.Control, Keys.D8, 18);
            HotKeyManager.RegisterSystemHotKey(Handle, Keys.Control, Keys.D0, 10);

            GetStartupKeyValue();
            if (!string.IsNullOrWhiteSpace(CurrentStartupPath))
            {
                try
                {
                    var (path, args) = ParsePathAndArgs(CurrentStartupPath);
                    Process.Start(path,args);
                }
                catch (Exception)
                {
                }
            }
        }

        #region Media Session Handlers
        private void MediaManager_HandleNewSession(MediaSession mediaSession) => currentSession = mediaSession;
        private async void Play_Pause()
        {
            if (currentSession == null)
                return;

            var controlsInfo = currentSession.ControlSession.GetPlaybackInfo().Controls;

            if (controlsInfo.IsPauseEnabled == true)
            {
                await currentSession.ControlSession.TryPauseAsync();
                play_pause_bt.Text = "Play";
                playToolStripMenuItem.Text = "Play";
            }
            else if (controlsInfo.IsPlayEnabled == true)
            {
                await currentSession.ControlSession.TryPlayAsync();
                play_pause_bt.Text = "Pause";
                playToolStripMenuItem.Text = "Pause";
            }
        }
        private async void Next()
        {
            if (currentSession == null)
                return;

            await currentSession.ControlSession.TrySkipNextAsync();
        }
        private async void Prev()
        {
            if (currentSession == null)
                return;

            await currentSession.ControlSession.TrySkipPreviousAsync();
        }
        #endregion

        #region Form controls event handlers
        private void play_pause_bt_ClickAsync(object sender, EventArgs e) => Play_Pause();
        private void Next_Bt_Click(object sender, EventArgs e) => Next(); 
        private void Prev_bt_Click(object sender, EventArgs e) => Prev();
        private void Exit_bt_Click(object sender, EventArgs e) => Exit();
        private void Hide_Bt_Click(object sender, EventArgs e) => Hide();
        private void Ui_Shown(object sender, EventArgs e) => Hide();
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Exit(); 
        private void showToolStripMenuItem_Click(object sender, EventArgs e) => Show();
        private void nextToolStripMenuItem_Click(object sender, EventArgs e) => Next();
        private void previousToolStripMenuItem_Click(object sender, EventArgs e) => Prev(); 
        private void playToolStripMenuItem_Click(object sender, EventArgs e) => Play_Pause();
        
        // Hotkey message handler
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            // Check if we have received a hotkey message
            if (m.Msg == WM_HOTKEY)
            {
                switch(m.WParam.ToInt32())
                {
                    case 19:
                        Play_Pause();
                        break;
                    case 18:
                        Prev();
                        break;
                    case 10:
                        Next();
                        break;
                }
            }
        }
        
        // Replace minimize by hide to tray
        private void Ui_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }
        #endregion

        #region Startup App Handling
        private void AppOnStartup_TextChanged(object sender, EventArgs e)
        {
            if (AppOnStartup.Text.Length < 1)
            {
                SetStartupKeyValue(string.Empty);
            }
        }
        private void SetStartupKeyValue(string path)
        {
            try
            {
                using (var key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(AppOnStartupKey))
                {
                    if (key != null)
                    {
                        key.SetValue("AppOnStartupPath", path);
                        GetStartupKeyValue();
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        private void GetStartupKeyValue()
        {
            try
            {
                using (var key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(AppOnStartupKey))
                {
                    if (key != null)
                    {
                        var value = key.GetValue("AppOnStartupPath") as string;
                        if (!string.IsNullOrWhiteSpace(value))
                        {
                            CurrentStartupPath = value;
                            AppOnStartup.Text = CurrentStartupPath;
                        }
                        else
                        {
                            CurrentStartupPath = null;
                            AppOnStartup.Text = "";
                        }
                    }
                }
            }
            catch { }
        }
        private void AppOnStartup_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SetStartupKeyValue(AppOnStartup.Text);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        public static (string path, string args) ParsePathAndArgs(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return (null, null);

            input = input.Trim();

            // If the path is quoted, find the closing quote
            if (input.StartsWith("\""))
            {
                int quoteEnd = input.IndexOf('\"', 1);
                if (quoteEnd > 0)
                {
                    string path = input.Substring(0, quoteEnd + 1).Trim();
                    string args = input.Substring(quoteEnd + 1).Trim();
                    return string.IsNullOrEmpty(args) ? (path, null) : (path, args);
                }
            }

            // If not quoted, split on first whitespace followed by / or -
            var parts = input.Split(new[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 2 && (parts[1].StartsWith("/") || parts[1].StartsWith("-")))
            {
                return (parts[0], parts[1]);
            }
            else
            {
                return (input, null);
            }
        }

        #endregion

        private void Exit()
        {
            HotKeyManager.UnregisterSystemHotKey(Handle, 10);
            HotKeyManager.UnregisterSystemHotKey(Handle, 19);
            HotKeyManager.UnregisterSystemHotKey(Handle, 18);
            Environment.Exit(0);
        }

    }
}
