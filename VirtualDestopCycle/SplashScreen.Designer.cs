namespace VirtualDesktopManager
{
	partial class SplashScreen
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
			this.labelDesktop = new System.Windows.Forms.Label();
			this.labelNumber = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelDesktop
			// 
			this.labelDesktop.BackColor = System.Drawing.SystemColors.Desktop;
			this.labelDesktop.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelDesktop.Font = new System.Drawing.Font("Garamond", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDesktop.ForeColor = System.Drawing.Color.GhostWhite;
			this.labelDesktop.Location = new System.Drawing.Point(0, 0);
			this.labelDesktop.Name = "labelDesktop";
			this.labelDesktop.Size = new System.Drawing.Size(296, 67);
			this.labelDesktop.TabIndex = 0;
			this.labelDesktop.Text = "Desktop";
			this.labelDesktop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelNumber
			// 
			this.labelNumber.BackColor = System.Drawing.SystemColors.Desktop;
			this.labelNumber.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelNumber.Font = new System.Drawing.Font("Garamond", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNumber.ForeColor = System.Drawing.Color.GhostWhite;
			this.labelNumber.Location = new System.Drawing.Point(0, 67);
			this.labelNumber.Name = "labelNumber";
			this.labelNumber.Size = new System.Drawing.Size(296, 206);
			this.labelNumber.TabIndex = 1;
			this.labelNumber.Text = "1";
			this.labelNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SplashScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(296, 273);
			this.Controls.Add(this.labelNumber);
			this.Controls.Add(this.labelDesktop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MinimizeBox = false;
			this.Name = "SplashScreen";
			this.Text = "SplashScreen";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label labelDesktop;
		public System.Windows.Forms.Label labelNumber;
	}
}