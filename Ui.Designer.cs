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
            this.play_pause_bt = new System.Windows.Forms.Button();
            this.Next_Bt = new System.Windows.Forms.Button();
            this.Prev_bt = new System.Windows.Forms.Button();
            this.Exit_bt = new System.Windows.Forms.Button();
            this.Hide_Bt = new System.Windows.Forms.Button();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // play_pause_bt
            // 
            this.play_pause_bt.Location = new System.Drawing.Point(93, 12);
            this.play_pause_bt.Name = "play_pause_bt";
            this.play_pause_bt.Size = new System.Drawing.Size(86, 40);
            this.play_pause_bt.TabIndex = 0;
            this.play_pause_bt.Text = "Play/Pause";
            this.play_pause_bt.UseVisualStyleBackColor = true;
            this.play_pause_bt.Click += new System.EventHandler(this.play_pause_bt_ClickAsync);
            // 
            // Next_Bt
            // 
            this.Next_Bt.Location = new System.Drawing.Point(185, 12);
            this.Next_Bt.Name = "Next_Bt";
            this.Next_Bt.Size = new System.Drawing.Size(75, 40);
            this.Next_Bt.TabIndex = 1;
            this.Next_Bt.Text = "Next";
            this.Next_Bt.UseVisualStyleBackColor = true;
            this.Next_Bt.Click += new System.EventHandler(this.Next_Bt_Click);
            // 
            // Prev_bt
            // 
            this.Prev_bt.Location = new System.Drawing.Point(12, 12);
            this.Prev_bt.Name = "Prev_bt";
            this.Prev_bt.Size = new System.Drawing.Size(75, 40);
            this.Prev_bt.TabIndex = 2;
            this.Prev_bt.Text = "Previous";
            this.Prev_bt.UseVisualStyleBackColor = true;
            this.Prev_bt.Click += new System.EventHandler(this.Prev_bt_Click);
            // 
            // Exit_bt
            // 
            this.Exit_bt.Location = new System.Drawing.Point(12, 58);
            this.Exit_bt.Name = "Exit_bt";
            this.Exit_bt.Size = new System.Drawing.Size(115, 23);
            this.Exit_bt.TabIndex = 3;
            this.Exit_bt.Text = "Exit";
            this.Exit_bt.UseVisualStyleBackColor = true;
            this.Exit_bt.Click += new System.EventHandler(this.Exit_bt_Click);
            // 
            // Hide_Bt
            // 
            this.Hide_Bt.Location = new System.Drawing.Point(145, 58);
            this.Hide_Bt.Name = "Hide_Bt";
            this.Hide_Bt.Size = new System.Drawing.Size(114, 23);
            this.Hide_Bt.TabIndex = 4;
            this.Hide_Bt.Text = "Hide";
            this.Hide_Bt.UseVisualStyleBackColor = true;
            this.Hide_Bt.Click += new System.EventHandler(this.Hide_Bt_Click);
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.TrayMenu;
            this.TrayIcon.Icon = global::MediaSessionHotKey.Properties.Resources.media;
            this.TrayIcon.Text = "Windows Media Session Controls";
            this.TrayIcon.Visible = true;
            // 
            // TrayMenu
            // 
            this.TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextToolStripMenuItem,
            this.playToolStripMenuItem,
            this.previousToolStripMenuItem,
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.TrayMenu.Name = "TrayMenu";
            this.TrayMenu.Size = new System.Drawing.Size(139, 114);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.nextToolStripMenuItem.Text = "Next";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.playToolStripMenuItem.Text = "Play / Pause";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // previousToolStripMenuItem
            // 
            this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            this.previousToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.previousToolStripMenuItem.Text = "Previous";
            this.previousToolStripMenuItem.Click += new System.EventHandler(this.previousToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Ui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 89);
            this.Controls.Add(this.Hide_Bt);
            this.Controls.Add(this.Exit_bt);
            this.Controls.Add(this.Prev_bt);
            this.Controls.Add(this.Next_Bt);
            this.Controls.Add(this.play_pause_bt);
            this.Icon = global::MediaSessionHotKey.Properties.Resources.media;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ui";
            this.Opacity = 0.8D;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Windows Media Sesion";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.Ui_Shown);
            this.TrayMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button play_pause_bt;
        private System.Windows.Forms.Button Next_Bt;
        private System.Windows.Forms.Button Prev_bt;
        private System.Windows.Forms.Button Exit_bt;
        private System.Windows.Forms.Button Hide_Bt;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ContextMenuStrip TrayMenu;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

