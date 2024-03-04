using System;
using System.Windows.Forms;
using WindowsMediaController;
using static WindowsMediaController.MediaManager;

namespace MediaSessionHotKey
{

    public partial class Ui : Form
    {
        private static readonly MediaManager mediaManager = new MediaManager();
        private static MediaSession currentSession = null;
        private const int WM_HOTKEY = 0x0312;
        public Ui()
        {
            InitializeComponent();
            mediaManager.OnAnySessionOpened += MediaManager_HandleNewSession;
            mediaManager.OnFocusedSessionChanged += MediaManager_HandleNewSession;
            mediaManager.Start();
           
            HotKeyManager.RegisterSystemHotKey(Handle, Keys.Control, Keys.D9, 19);
            HotKeyManager.RegisterSystemHotKey(Handle, Keys.Control, Keys.D8, 18);
            HotKeyManager.RegisterSystemHotKey(Handle, Keys.Control, Keys.D0, 10);
        }
        private void MediaManager_HandleNewSession(MediaSession mediaSession) { currentSession = mediaSession;}
        private void Exit()
        {
            HotKeyManager.UnregisterSystemHotKey(Handle, 10);
            HotKeyManager.UnregisterSystemHotKey(Handle, 19);
            HotKeyManager.UnregisterSystemHotKey(Handle, 18);
            Environment.Exit(0);
        }
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
        private void play_pause_bt_ClickAsync(object sender, EventArgs e) { Play_Pause(); }
        private void Next_Bt_Click(object sender, EventArgs e) { Next(); }
        private void Prev_bt_Click(object sender, EventArgs e) { Prev(); }
        private void Exit_bt_Click(object sender, EventArgs e) { Exit(); }
        private void Hide_Bt_Click(object sender, EventArgs e) { Hide(); }
        private void Ui_Shown(object sender, EventArgs e) { Hide(); }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) { Exit(); }
        private void showToolStripMenuItem_Click(object sender, EventArgs e) { Show(); }
        private void nextToolStripMenuItem_Click(object sender, EventArgs e) { Next(); }
        private void previousToolStripMenuItem_Click(object sender, EventArgs e) { Prev(); }
        private void playToolStripMenuItem_Click(object sender, EventArgs e) { Play_Pause();}
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
    }
}
