namespace MediaSessionHotKey
{
    partial class Ui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ui));
            this.play_pause_bt = new MaterialSkin.Controls.MaterialButton();
            this.Next_Bt = new MaterialSkin.Controls.MaterialButton();
            this.Prev_bt = new MaterialSkin.Controls.MaterialButton();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayMenu = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Center_Panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AppOnStartup = new MaterialSkin.Controls.MaterialTextBox2();
            this.TrayMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Center_Panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // play_pause_bt
            // 
            this.play_pause_bt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.play_pause_bt.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.play_pause_bt.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.play_pause_bt.Depth = 0;
            this.play_pause_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.play_pause_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_pause_bt.HighEmphasis = true;
            this.play_pause_bt.Icon = null;
            this.play_pause_bt.Location = new System.Drawing.Point(50, 0);
            this.play_pause_bt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.play_pause_bt.MouseState = MaterialSkin.MouseState.HOVER;
            this.play_pause_bt.Name = "play_pause_bt";
            this.play_pause_bt.NoAccentTextColor = System.Drawing.Color.Empty;
            this.play_pause_bt.Size = new System.Drawing.Size(162, 35);
            this.play_pause_bt.TabIndex = 0;
            this.play_pause_bt.Text = "Play/Pause";
            this.play_pause_bt.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.play_pause_bt.UseAccentColor = false;
            this.play_pause_bt.UseVisualStyleBackColor = true;
            this.play_pause_bt.Click += new System.EventHandler(this.play_pause_bt_ClickAsync);
            // 
            // Next_Bt
            // 
            this.Next_Bt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Next_Bt.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Next_Bt.Depth = 0;
            this.Next_Bt.Dock = System.Windows.Forms.DockStyle.Right;
            this.Next_Bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_Bt.HighEmphasis = true;
            this.Next_Bt.Icon = null;
            this.Next_Bt.Location = new System.Drawing.Point(336, 10);
            this.Next_Bt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Next_Bt.MouseState = MaterialSkin.MouseState.HOVER;
            this.Next_Bt.Name = "Next_Bt";
            this.Next_Bt.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Next_Bt.Size = new System.Drawing.Size(64, 35);
            this.Next_Bt.TabIndex = 1;
            this.Next_Bt.Text = ">";
            this.Next_Bt.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Next_Bt.UseAccentColor = false;
            this.Next_Bt.UseVisualStyleBackColor = true;
            this.Next_Bt.Click += new System.EventHandler(this.Next_Bt_Click);
            // 
            // Prev_bt
            // 
            this.Prev_bt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Prev_bt.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Prev_bt.Depth = 0;
            this.Prev_bt.Dock = System.Windows.Forms.DockStyle.Left;
            this.Prev_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prev_bt.HighEmphasis = true;
            this.Prev_bt.Icon = null;
            this.Prev_bt.Location = new System.Drawing.Point(10, 10);
            this.Prev_bt.Margin = new System.Windows.Forms.Padding(0);
            this.Prev_bt.MouseState = MaterialSkin.MouseState.HOVER;
            this.Prev_bt.Name = "Prev_bt";
            this.Prev_bt.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Prev_bt.Size = new System.Drawing.Size(64, 35);
            this.Prev_bt.TabIndex = 2;
            this.Prev_bt.Text = "<";
            this.Prev_bt.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Prev_bt.UseAccentColor = false;
            this.Prev_bt.UseVisualStyleBackColor = true;
            this.Prev_bt.Click += new System.EventHandler(this.Prev_bt_Click);
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.TrayMenu;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "Windows Media Session Controls";
            this.TrayIcon.Visible = true;
            // 
            // TrayMenu
            // 
            this.TrayMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TrayMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TrayMenu.Depth = 0;
            this.TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextToolStripMenuItem,
            this.playToolStripMenuItem,
            this.previousToolStripMenuItem,
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.TrayMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.TrayMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.TrayMenu.Name = "TrayMenu";
            this.TrayMenu.ShowImageMargin = false;
            this.TrayMenu.ShowItemToolTips = false;
            this.TrayMenu.Size = new System.Drawing.Size(114, 114);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.nextToolStripMenuItem.Text = "Next";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.playToolStripMenuItem.Text = "Play / Pause";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // previousToolStripMenuItem
            // 
            this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            this.previousToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.previousToolStripMenuItem.Text = "Previous";
            this.previousToolStripMenuItem.Click += new System.EventHandler(this.previousToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Center_Panel);
            this.panel1.Controls.Add(this.Next_Bt);
            this.panel1.Controls.Add(this.Prev_bt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 24);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(410, 55);
            this.panel1.TabIndex = 5;
            // 
            // Center_Panel
            // 
            this.Center_Panel.Controls.Add(this.play_pause_bt);
            this.Center_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Center_Panel.Location = new System.Drawing.Point(74, 10);
            this.Center_Panel.Name = "Center_Panel";
            this.Center_Panel.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.Center_Panel.Size = new System.Drawing.Size(262, 35);
            this.Center_Panel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AppOnStartup);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 79);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(410, 75);
            this.panel2.TabIndex = 6;
            // 
            // AppOnStartup
            // 
            this.AppOnStartup.AnimateReadOnly = false;
            this.AppOnStartup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AppOnStartup.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.AppOnStartup.Depth = 0;
            this.AppOnStartup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppOnStartup.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AppOnStartup.HideSelection = true;
            this.AppOnStartup.Hint = "Path of a music application to open on startup";
            this.AppOnStartup.LeadingIcon = null;
            this.AppOnStartup.Location = new System.Drawing.Point(10, 10);
            this.AppOnStartup.MaxLength = 32767;
            this.AppOnStartup.MouseState = MaterialSkin.MouseState.OUT;
            this.AppOnStartup.Name = "AppOnStartup";
            this.AppOnStartup.PasswordChar = '\0';
            this.AppOnStartup.PrefixSuffixText = null;
            this.AppOnStartup.ReadOnly = false;
            this.AppOnStartup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AppOnStartup.SelectedText = "";
            this.AppOnStartup.SelectionLength = 0;
            this.AppOnStartup.SelectionStart = 0;
            this.AppOnStartup.ShortcutsEnabled = true;
            this.AppOnStartup.Size = new System.Drawing.Size(390, 48);
            this.AppOnStartup.TabIndex = 4;
            this.AppOnStartup.TabStop = false;
            this.AppOnStartup.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AppOnStartup.TrailingIcon = null;
            this.AppOnStartup.UseSystemPasswordChar = false;
            this.AppOnStartup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AppOnStartup_KeyDown);
            this.AppOnStartup.TextChanged += new System.EventHandler(this.AppOnStartup_TextChanged);
            // 
            // Ui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 157);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Ui";
            this.Opacity = 0.95D;
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Windows Media Sesion";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.Ui_Shown);
            this.Resize += new System.EventHandler(this.Ui_Resize);
            this.TrayMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Center_Panel.ResumeLayout(false);
            this.Center_Panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton play_pause_bt;
        private MaterialSkin.Controls.MaterialButton Next_Bt;
        private MaterialSkin.Controls.MaterialButton Prev_bt;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private MaterialSkin.Controls.MaterialContextMenuStrip TrayMenu;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialTextBox2 AppOnStartup;
        private System.Windows.Forms.Panel Center_Panel;
    }
}

