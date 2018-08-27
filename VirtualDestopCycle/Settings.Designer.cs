namespace VirtualDesktopManager
{
    partial class Settings
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
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.desktopsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.newDesktopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeDesktopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.removeButton = new System.Windows.Forms.Button();
			this.downButton = new System.Windows.Forms.Button();
			this.upButton = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.addFileButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.labelStatus = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.labelDebug = new System.Windows.Forms.Label();
			this.contextMenuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.Icon = global::VirtualDesktopManager.Properties.Resources.mainIco;
			this.notifyIcon1.Text = "Virtual Desktop Manager";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desktopsToolStripMenuItem,
            this.toolStripSeparator1,
            this.newDesktopToolStripMenuItem,
            this.closeDesktopToolStripMenuItem,
            this.toolStripSeparator2,
            this.settingsToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(150, 148);
			// 
			// desktopsToolStripMenuItem
			// 
			this.desktopsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.desktopsToolStripMenuItem.Name = "desktopsToolStripMenuItem";
			this.desktopsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.desktopsToolStripMenuItem.Text = "Desktops";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(146, 6);
			// 
			// newDesktopToolStripMenuItem
			// 
			this.newDesktopToolStripMenuItem.Name = "newDesktopToolStripMenuItem";
			this.newDesktopToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.newDesktopToolStripMenuItem.Text = "New Desktop";
			this.newDesktopToolStripMenuItem.Click += new System.EventHandler(this.newDesktopToolStripMenuItem_Click);
			// 
			// closeDesktopToolStripMenuItem
			// 
			this.closeDesktopToolStripMenuItem.Name = "closeDesktopToolStripMenuItem";
			this.closeDesktopToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.closeDesktopToolStripMenuItem.Text = "Close Desktop";
			this.closeDesktopToolStripMenuItem.Click += new System.EventHandler(this.closeDesktopToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(146, 6);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.settingsToolStripMenuItem.Text = "Settings";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
			// 
			// refreshToolStripMenuItem
			// 
			this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
			this.refreshToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.refreshToolStripMenuItem.Text = "Refresh";
			this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.ForeColor = System.Drawing.Color.Black;
			this.checkBox1.Location = new System.Drawing.Point(14, 54);
			this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(322, 19);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "Use alternate key combination (Shift+Alt+Left/Right)";
			this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.removeButton);
			this.groupBox1.Controls.Add(this.downButton);
			this.groupBox1.Controls.Add(this.upButton);
			this.groupBox1.Controls.Add(this.listView1);
			this.groupBox1.Controls.Add(this.addFileButton);
			this.groupBox1.Controls.Add(this.saveButton);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Font = new System.Drawing.Font("Roboto Slab", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(8, 9);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.groupBox1.Size = new System.Drawing.Size(593, 347);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Settings";
			// 
			// removeButton
			// 
			this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.removeButton.BackColor = System.Drawing.SystemColors.HotTrack;
			this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.removeButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.removeButton.ForeColor = System.Drawing.Color.White;
			this.removeButton.Location = new System.Drawing.Point(378, 201);
			this.removeButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.removeButton.Name = "removeButton";
			this.removeButton.Size = new System.Drawing.Size(144, 37);
			this.removeButton.TabIndex = 7;
			this.removeButton.Text = "Remove file";
			this.removeButton.UseVisualStyleBackColor = false;
			this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
			// 
			// downButton
			// 
			this.downButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.downButton.BackColor = System.Drawing.SystemColors.HotTrack;
			this.downButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.downButton.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.downButton.ForeColor = System.Drawing.Color.White;
			this.downButton.Location = new System.Drawing.Point(539, 158);
			this.downButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.downButton.Name = "downButton";
			this.downButton.Size = new System.Drawing.Size(41, 37);
			this.downButton.TabIndex = 6;
			this.downButton.Text = "â";
			this.downButton.UseVisualStyleBackColor = false;
			this.downButton.Click += new System.EventHandler(this.downButton_Click);
			// 
			// upButton
			// 
			this.upButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.upButton.BackColor = System.Drawing.SystemColors.HotTrack;
			this.upButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.upButton.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.upButton.ForeColor = System.Drawing.Color.White;
			this.upButton.Location = new System.Drawing.Point(539, 98);
			this.upButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.upButton.Name = "upButton";
			this.upButton.Size = new System.Drawing.Size(41, 37);
			this.upButton.TabIndex = 5;
			this.upButton.Text = "á";
			this.upButton.UseVisualStyleBackColor = false;
			this.upButton.Click += new System.EventHandler(this.upButton_Click);
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(14, 98);
			this.listView1.Name = "listView1";
			this.listView1.ShowGroups = false;
			this.listView1.ShowItemToolTips = true;
			this.listView1.Size = new System.Drawing.Size(508, 97);
			this.listView1.TabIndex = 4;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// addFileButton
			// 
			this.addFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.addFileButton.BackColor = System.Drawing.SystemColors.HotTrack;
			this.addFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addFileButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addFileButton.ForeColor = System.Drawing.Color.White;
			this.addFileButton.Location = new System.Drawing.Point(230, 201);
			this.addFileButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.addFileButton.Name = "addFileButton";
			this.addFileButton.Size = new System.Drawing.Size(144, 37);
			this.addFileButton.TabIndex = 3;
			this.addFileButton.Text = "Add background";
			this.addFileButton.UseVisualStyleBackColor = false;
			this.addFileButton.Click += new System.EventHandler(this.addFileButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.saveButton.BackColor = System.Drawing.SystemColors.HotTrack;
			this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.saveButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveButton.ForeColor = System.Drawing.Color.White;
			this.saveButton.Location = new System.Drawing.Point(477, 304);
			this.saveButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(103, 37);
			this.saveButton.TabIndex = 2;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = false;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox1.Location = new System.Drawing.Point(8, 363);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(171, 76);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// labelStatus
			// 
			this.labelStatus.AutoSize = true;
			this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.labelStatus.Location = new System.Drawing.Point(184, 363);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(0, 17);
			this.labelStatus.TabIndex = 5;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// labelDebug
			// 
			this.labelDebug.AutoSize = true;
			this.labelDebug.ForeColor = System.Drawing.Color.Blue;
			this.labelDebug.Location = new System.Drawing.Point(566, 429);
			this.labelDebug.Name = "labelDebug";
			this.labelDebug.Size = new System.Drawing.Size(37, 13);
			this.labelDebug.TabIndex = 6;
			this.labelDebug.Text = "debug";
			this.labelDebug.Click += new System.EventHandler(this.labelDebug_Click);
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(609, 451);
			this.Controls.Add(this.labelDebug);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Margin = new System.Windows.Forms.Padding(1);
			this.Name = "Settings";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Virtual Desktop Manager";
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this.Load += new System.EventHandler(this.Settings_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button addFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button removeButton;
		private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
		private System.Windows.Forms.Label labelDebug;
		private System.Windows.Forms.ToolStripMenuItem desktopsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newDesktopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeDesktopToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
	}
}

