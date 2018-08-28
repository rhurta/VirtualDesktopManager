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
			this.groupBoxSettings = new System.Windows.Forms.GroupBox();
			this.removeButton = new System.Windows.Forms.Button();
			this.downButton = new System.Windows.Forms.Button();
			this.upButton = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.addFileButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.labelStatus = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.timerCurrentDesktopSplash = new System.Windows.Forms.Timer(this.components);
			this.checkBoxStartup = new System.Windows.Forms.CheckBox();
			this.groupBoxHotKeys = new System.Windows.Forms.GroupBox();
			this.labelSwitchToSpecificDesktop = new System.Windows.Forms.Label();
			this.labelMoveToNextLastDesktop = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.contextMenuStrip1.SuspendLayout();
			this.groupBoxSettings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBoxHotKeys.SuspendLayout();
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
			// groupBoxSettings
			// 
			this.groupBoxSettings.BackColor = System.Drawing.Color.White;
			this.groupBoxSettings.Controls.Add(this.removeButton);
			this.groupBoxSettings.Controls.Add(this.checkBoxStartup);
			this.groupBoxSettings.Controls.Add(this.downButton);
			this.groupBoxSettings.Controls.Add(this.upButton);
			this.groupBoxSettings.Controls.Add(this.saveButton);
			this.groupBoxSettings.Controls.Add(this.pictureBox1);
			this.groupBoxSettings.Controls.Add(this.listView1);
			this.groupBoxSettings.Controls.Add(this.addFileButton);
			this.groupBoxSettings.Controls.Add(this.checkBox1);
			this.groupBoxSettings.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxSettings.ForeColor = System.Drawing.Color.Black;
			this.groupBoxSettings.Location = new System.Drawing.Point(8, 9);
			this.groupBoxSettings.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.groupBoxSettings.Name = "groupBoxSettings";
			this.groupBoxSettings.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.groupBoxSettings.Size = new System.Drawing.Size(586, 338);
			this.groupBoxSettings.TabIndex = 3;
			this.groupBoxSettings.TabStop = false;
			this.groupBoxSettings.Text = "Settings";
			// 
			// removeButton
			// 
			this.removeButton.BackColor = System.Drawing.SystemColors.HotTrack;
			this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.removeButton.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.removeButton.ForeColor = System.Drawing.Color.White;
			this.removeButton.Location = new System.Drawing.Point(224, 201);
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
			this.downButton.BackColor = System.Drawing.SystemColors.HotTrack;
			this.downButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.downButton.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.downButton.ForeColor = System.Drawing.Color.White;
			this.downButton.Location = new System.Drawing.Point(533, 158);
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
			this.upButton.BackColor = System.Drawing.SystemColors.HotTrack;
			this.upButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.upButton.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.upButton.ForeColor = System.Drawing.Color.White;
			this.upButton.Location = new System.Drawing.Point(533, 98);
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
			this.listView1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(8, 98);
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
			this.addFileButton.BackColor = System.Drawing.SystemColors.HotTrack;
			this.addFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addFileButton.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addFileButton.ForeColor = System.Drawing.Color.White;
			this.addFileButton.Location = new System.Drawing.Point(372, 201);
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
			this.saveButton.BackColor = System.Drawing.SystemColors.HotTrack;
			this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.saveButton.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveButton.ForeColor = System.Drawing.Color.White;
			this.saveButton.Location = new System.Drawing.Point(471, 288);
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
			this.pictureBox1.Location = new System.Drawing.Point(14, 249);
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
			// timerCurrentDesktopSplash
			// 
			this.timerCurrentDesktopSplash.Enabled = true;
			this.timerCurrentDesktopSplash.Interval = 1500;
			// 
			// checkBoxStartup
			// 
			this.checkBoxStartup.AutoSize = true;
			this.checkBoxStartup.Font = new System.Drawing.Font("Roboto", 9.75F);
			this.checkBoxStartup.Location = new System.Drawing.Point(440, 263);
			this.checkBoxStartup.Name = "checkBoxStartup";
			this.checkBoxStartup.Size = new System.Drawing.Size(134, 19);
			this.checkBoxStartup.TabIndex = 8;
			this.checkBoxStartup.Text = "Automatic Startup?";
			this.checkBoxStartup.UseVisualStyleBackColor = true;
			// 
			// groupBoxHotKeys
			// 
			this.groupBoxHotKeys.Controls.Add(this.label10);
			this.groupBoxHotKeys.Controls.Add(this.label9);
			this.groupBoxHotKeys.Controls.Add(this.label8);
			this.groupBoxHotKeys.Controls.Add(this.label7);
			this.groupBoxHotKeys.Controls.Add(this.label6);
			this.groupBoxHotKeys.Controls.Add(this.label5);
			this.groupBoxHotKeys.Controls.Add(this.label4);
			this.groupBoxHotKeys.Controls.Add(this.label3);
			this.groupBoxHotKeys.Controls.Add(this.label2);
			this.groupBoxHotKeys.Controls.Add(this.label1);
			this.groupBoxHotKeys.Controls.Add(this.labelMoveToNextLastDesktop);
			this.groupBoxHotKeys.Controls.Add(this.labelSwitchToSpecificDesktop);
			this.groupBoxHotKeys.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxHotKeys.Location = new System.Drawing.Point(8, 353);
			this.groupBoxHotKeys.Name = "groupBoxHotKeys";
			this.groupBoxHotKeys.Size = new System.Drawing.Size(586, 100);
			this.groupBoxHotKeys.TabIndex = 6;
			this.groupBoxHotKeys.TabStop = false;
			this.groupBoxHotKeys.Text = "Hotkeys";
			// 
			// labelSwitchToSpecificDesktop
			// 
			this.labelSwitchToSpecificDesktop.AutoSize = true;
			this.labelSwitchToSpecificDesktop.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSwitchToSpecificDesktop.Location = new System.Drawing.Point(6, 23);
			this.labelSwitchToSpecificDesktop.Name = "labelSwitchToSpecificDesktop";
			this.labelSwitchToSpecificDesktop.Size = new System.Drawing.Size(151, 14);
			this.labelSwitchToSpecificDesktop.TabIndex = 0;
			this.labelSwitchToSpecificDesktop.Text = "Switch To Specific Desktop";
			// 
			// labelMoveToNextLastDesktop
			// 
			this.labelMoveToNextLastDesktop.AutoSize = true;
			this.labelMoveToNextLastDesktop.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMoveToNextLastDesktop.Location = new System.Drawing.Point(6, 50);
			this.labelMoveToNextLastDesktop.Name = "labelMoveToNextLastDesktop";
			this.labelMoveToNextLastDesktop.Size = new System.Drawing.Size(154, 14);
			this.labelMoveToNextLastDesktop.TabIndex = 1;
			this.labelMoveToNextLastDesktop.Text = "Move To Next/Last Desktop";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(134, 14);
			this.label1.TabIndex = 2;
			this.label1.Text = "Show Desktop Manager";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(333, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 14);
			this.label2.TabIndex = 3;
			this.label2.Text = "Create New Desktop";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(333, 50);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(127, 14);
			this.label3.TabIndex = 4;
			this.label3.Text = "Close Current Desktop";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(171, 23);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 14);
			this.label4.TabIndex = 5;
			this.label4.Text = "Shift + Alt + (1-9)";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(171, 50);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(134, 14);
			this.label5.TabIndex = 6;
			this.label5.Text = "Ctrl + Win + (Right/Left)";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(171, 74);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 14);
			this.label6.TabIndex = 7;
			this.label6.Text = "Win + Tab";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(474, 23);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(81, 14);
			this.label7.TabIndex = 8;
			this.label7.Text = "Ctrl + Win + D";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(474, 50);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(87, 14);
			this.label8.TabIndex = 9;
			this.label8.Text = "Ctrl + Win + F4";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(333, 74);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(107, 14);
			this.label9.TabIndex = 10;
			this.label9.Text = "Gray Tone Desktop";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(474, 74);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(81, 14);
			this.label10.TabIndex = 11;
			this.label10.Text = "Ctrl + Win + C";
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(602, 461);
			this.Controls.Add(this.groupBoxHotKeys);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.groupBoxSettings);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(1);
			this.MinimumSize = new System.Drawing.Size(618, 500);
			this.Name = "Settings";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Virtual Desktop Manager";
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this.Load += new System.EventHandler(this.MenuSettings_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			this.groupBoxSettings.ResumeLayout(false);
			this.groupBoxSettings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBoxHotKeys.ResumeLayout(false);
			this.groupBoxHotKeys.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBoxSettings;
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
		private System.Windows.Forms.ToolStripMenuItem desktopsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newDesktopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeDesktopToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Timer timerCurrentDesktopSplash;
		private System.Windows.Forms.CheckBox checkBoxStartup;
		private System.Windows.Forms.GroupBox groupBoxHotKeys;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelMoveToNextLastDesktop;
		private System.Windows.Forms.Label labelSwitchToSpecificDesktop;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
	}
}

