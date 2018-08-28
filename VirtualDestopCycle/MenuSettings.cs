using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Input;
using System.Runtime.InteropServices;
using WindowsDesktop;
using GlobalHotKey;
using System.Drawing;
using System.IO;
using System.Threading;
using System.ComponentModel;
using Timers = System.Timers;


namespace VirtualDesktopManager
{
    public partial class Settings : Form
    {
        [DllImport("user32.dll", ExactSpelling = true)]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        private IList<VirtualDesktop> desktops;
        private IntPtr[] activePrograms;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        extern static bool DestroyIcon(IntPtr handle);

		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRectRgn
		(
			int nLeftRect,     // x-coordinate of upper-left corner
			int nTopRect,      // y-coordinate of upper-left corner
			int nRightRect,    // x-coordinate of lower-right corner
			int nBottomRect,   // y-coordinate of lower-right corner
			int nWidthEllipse, // height of ellipse
			int nHeightEllipse // width of ellipse
		);

		private HotKeyManager _rightHotkey;
        private HotKeyManager _leftHotkey;
        private HotKeyManager _numberHotkey;

        private bool closeToTray;
        private bool useAltKeySettings;

        // APP STARTUP

        public Settings()
		{
			InitializeComponent();
			InitializeVariables();
			InitializeToolStripItems();
			InitializeBackgroundWorkers();
		}

		private void InitializeVariables()
		{
			handleChangedNumber();

			closeToTray = true;

			_rightHotkey = new HotKeyManager();
			_rightHotkey.KeyPressed += RightKeyManagerPressed;

			_leftHotkey = new HotKeyManager();
			_leftHotkey.KeyPressed += LeftKeyManagerPressed;

			_numberHotkey = new HotKeyManager();
			_numberHotkey.KeyPressed += NumberHotkeyPressed;

			VirtualDesktop.CurrentChanged += VirtualDesktop_CurrentChanged;
			VirtualDesktop.Created += VirtualDesktop_Added;
			VirtualDesktop.Destroyed += VirtualDesktop_Destroyed;

			this.FormClosing += MenuSettings_FormClosing;

			useAltKeySettings = Properties.Settings.Default.AltHotKey;
			checkBox1.Checked = useAltKeySettings;

			checkBoxStartup.Checked = Properties.Settings.Default.ApplicationStartup;

			listView1.Items.Clear();
			listView1.Columns.Add("File").Width = 400;
			foreach (var file in Properties.Settings.Default.DesktopBackgroundFiles)
			{
				listView1.Items.Add(NewListViewItem(file));
			}

            
        }

		private void InitializeToolStripItems()
		{
			var vDesktopNum = 1;
			(contextMenuStrip1.Items["desktopsToolStripMenuItem"] as ToolStripMenuItem)?.DropDown.Items.Clear();

			foreach (VirtualDesktop vDesktop in VirtualDesktop.GetDesktops())
			{
				var toolStripMenuItemDesktopChild = new ToolStripMenuItem();
				toolStripMenuItemDesktopChild.Text = string.Format("Desktop {0}", vDesktopNum);
				toolStripMenuItemDesktopChild.Font = new Font((contextMenuStrip1.Items["desktopsToolStripMenuItem"] as ToolStripMenuItem)?.Font.Name, 9);
				toolStripMenuItemDesktopChild.Click += ToolStripItem_OnClick;
				(contextMenuStrip1.Items["desktopsToolStripMenuItem"] as ToolStripMenuItem)?.DropDown.Items.Add(toolStripMenuItemDesktopChild);
				vDesktopNum++;
			}
		}

		private void InitializeBackgroundWorkers()
		{
			bwCheckVirtualDesktop.DoWork += bwCheckVirtualDesktop_DoWork;
			bwCheckVirtualDesktop.ProgressChanged += bwCheckVirtualDesktop_ProgressChanged;
			bwCheckVirtualDesktop.WorkerSupportsCancellation = true;
			bwCheckVirtualDesktop.WorkerReportsProgress = true;

            bwSplashTimer.DoWork += bwSplashTimer_DoWork;
            bwSplashTimer.ProgressChanged += bwSplashTimer_ProgressChanged;
            bwSplashTimer.RunWorkerCompleted += bwSplashTimer_WorkerCompleted;
			bwSplashTimer.WorkerSupportsCancellation = true;
            bwSplashTimer.WorkerReportsProgress = true;
		}

		// MAIN FORM

		private void MenuSettings_Load(object sender, EventArgs e)
		{
			bwCheckVirtualDesktop.RunWorkerAsync();

			labelStatus.Text = "";

			if (!useAltKeySettings)
				normalHotkeys();
			else
				alternateHotkeys();

			var desktop = initialDesktopState();
			changeTrayIcon();
            this.Visible = false;
		}

		private void MenuSettings_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (closeToTray)
			{
				e.Cancel = true;
				this.Visible = false;
				this.ShowInTaskbar = false;
				notifyIcon1.BalloonTipTitle = "Still Running...";
				notifyIcon1.BalloonTipText = "Right-click on the tray icon to exit.";
				notifyIcon1.ShowBalloonTip(2000);
			}
		}

		private void upButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (listView1.SelectedItems.Count > 0)
				{
					ListViewItem selected = listView1.SelectedItems[0];
					int indx = selected.Index;
					int totl = listView1.Items.Count;

					if (indx == 0)
					{
						listView1.Items.Remove(selected);
						listView1.Items.Insert(totl - 1, selected);
					}
					else
					{
						listView1.Items.Remove(selected);
						listView1.Items.Insert(indx - 1, selected);
					}
				}
				else
				{
					MessageBox.Show("You can only move one item at a time. Please select only one item and try again.",
						"Item Select", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				}
			}
			catch (Exception ex)
			{

			}
		}

		private void downButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (listView1.SelectedItems.Count > 0)
				{
					ListViewItem selected = listView1.SelectedItems[0];
					int indx = selected.Index;
					int totl = listView1.Items.Count;

					if (indx == totl - 1)
					{
						listView1.Items.Remove(selected);
						listView1.Items.Insert(0, selected);
					}
					else
					{
						listView1.Items.Remove(selected);
						listView1.Items.Insert(indx + 1, selected);
					}
				}
				else
				{
					MessageBox.Show("You can only move one item at a time. Please select only one item and try again.",
						"Item Select", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				}
			}
			catch (Exception ex)
			{
			}
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			_rightHotkey.Unregister(Key.Right, System.Windows.Input.ModifierKeys.Control | System.Windows.Input.ModifierKeys.Alt);
			_leftHotkey.Unregister(Key.Left, System.Windows.Input.ModifierKeys.Control | System.Windows.Input.ModifierKeys.Alt);
			_rightHotkey.Unregister(Key.Right, System.Windows.Input.ModifierKeys.Shift | System.Windows.Input.ModifierKeys.Alt);
			_leftHotkey.Unregister(Key.Left, System.Windows.Input.ModifierKeys.Shift | System.Windows.Input.ModifierKeys.Alt);

			if (checkBox1.Checked)
			{
				alternateHotkeys();
				Properties.Settings.Default.AltHotKey = true;
			}
			else
			{
				normalHotkeys();
				Properties.Settings.Default.AltHotKey = false;
			}

			if (checkBoxStartup.Checked)
			{
				string deskDir = Environment.GetFolderPath(Environment.SpecialFolder.Startup);

				using (StreamWriter writer = new StreamWriter(deskDir + "\\" + "VirtualDesktopManager" + ".url"))
				{
					string app = System.Reflection.Assembly.GetExecutingAssembly().Location;
					writer.WriteLine("[InternetShortcut]");
					writer.WriteLine("URL=file:///" + app);
					writer.WriteLine("IconIndex=0");
					string icon = app.Replace('\\', '/');
					writer.WriteLine("IconFile=" + icon);
					writer.Flush();
				}
				Properties.Settings.Default.ApplicationStartup = true;
			}
			else
			{
				string deskDir = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
				if (File.Exists(deskDir + "\\VirtualDesktopManager.url"))
					File.Delete(deskDir + "\\VirtualDesktopManager.url");
				Properties.Settings.Default.ApplicationStartup = false;
			}

			Properties.Settings.Default.DesktopBackgroundFiles.Clear();
			foreach (ListViewItem item in listView1.Items)
			{
				Properties.Settings.Default.DesktopBackgroundFiles.Add(item.Tag.ToString());
			}

			Properties.Settings.Default.Save();
			labelStatus.Text = "Changes were successful.";
		}

		private void addFileButton_Click(object sender, EventArgs e)
		{
			openFileDialog1.CheckFileExists = true;
			openFileDialog1.CheckPathExists = true;
			openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
			openFileDialog1.FilterIndex = 0;
			openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
			openFileDialog1.Multiselect = true;
			openFileDialog1.Title = "Select desktop background image";
			if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
			{
				foreach (string file in openFileDialog1.FileNames)
				{
					listView1.Items.Add(NewListViewItem(file));
				}
			}
		}

		private void removeButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (listView1.SelectedItems.Count > 0)
				{
					ListViewItem selected = listView1.SelectedItems[0];
					listView1.Items.Remove(selected);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// NOTIFICATION TRAY

		private void notifyIcon1_DoubleClick(object sender, EventArgs e)
		{
			openSettings();
		}

		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			openSettings();
		}

		private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
		{

			// Author: rootwo62

			InitializeVariables();
			InitializeToolStripItems();

		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_rightHotkey.Dispose();
			_leftHotkey.Dispose();
			_numberHotkey.Dispose();

			bwCheckVirtualDesktop.CancelAsync();
			bwSplashTimer.CancelAsync();
			bwCheckVirtualDesktop.Dispose();
			bwSplashTimer.Dispose();

			closeToTray = false;

			this.Close();
		}

		private void changeTrayIcon(int currentDesktopIndex = -1)
		{
			if (currentDesktopIndex == -1)
				currentDesktopIndex = getCurrentDesktopIndex();

			var desktopNumber = currentDesktopIndex + 1;
			var desktopNumberString = desktopNumber.ToString();

			var fontSize = 140;
			var xPlacement = 100;
			var yPlacement = 50;

			if (desktopNumber > 9 && desktopNumber < 100)
			{
				fontSize = 125;
				xPlacement = 75;
				yPlacement = 65;
			}
			else if (desktopNumber > 99)
			{
				fontSize = 80;
				xPlacement = 90;
				yPlacement = 100;
			}

			Bitmap newIcon = Properties.Resources.mainIcoPng;
			Font desktopNumberFont = new Font("Segoe UI", fontSize, FontStyle.Bold, GraphicsUnit.Pixel);

			var gr = Graphics.FromImage(newIcon);
			gr.DrawString(desktopNumberString, desktopNumberFont, Brushes.White, xPlacement, yPlacement);

			Icon numberedIcon = Icon.FromHandle(newIcon.GetHicon());
			notifyIcon1.Icon = numberedIcon;

			DestroyIcon(numberedIcon.Handle);
			desktopNumberFont.Dispose();
			newIcon.Dispose();
			gr.Dispose();
		}

		private void newDesktopToolStripMenuItem_Click(object sender, EventArgs e)
		{
			VirtualDesktop.Create();
			InitializeVariables();
			InitializeToolStripItems();
			VirtualDesktop.GetDesktops()[VirtualDesktop.GetDesktops().Count() - 1].Switch();
			ShowSplashVirtualDesktopSplashScreen();
		}

		private void closeDesktopToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (VirtualDesktop.GetDesktops().Count() > 1)
			{
				if (getCurrentDesktopIndex() > 0)
					VirtualDesktop.Current.Remove(VirtualDesktop.Current.GetLeft());
				else
					VirtualDesktop.Current.Remove(VirtualDesktop.Current.GetRight());
				InitializeVariables();
				InitializeToolStripItems();
			}
		}

		// VIRTUALDESKTOP

		VirtualDesktop initialDesktopState()
		{
			var desktop = VirtualDesktop.Current;
			int desktopIndex = getCurrentDesktopIndex();

			saveApplicationFocus(desktopIndex);

			return desktop;
		}

		private void VirtualDesktop_Added(object sender, VirtualDesktop e)
        {
            handleChangedNumber();
        }

        private void VirtualDesktop_Destroyed(object sender, VirtualDesktopDestroyEventArgs e)
        {
            handleChangedNumber();
        }

        private void VirtualDesktop_CurrentChanged(object sender, VirtualDesktopChangedEventArgs e)
        {
            // 0 == first
            int currentDesktopIndex = getCurrentDesktopIndex();

            string pictureFile = PickNthFile(currentDesktopIndex);
            if (pictureFile != null)
            {
                Native.SetBackground(pictureFile);
            }

            restoreApplicationFocus(currentDesktopIndex);
            changeTrayIcon(currentDesktopIndex);
		}

		private void ShowDesktopSwitchedNotification()
		{
			
			notifyIcon1.BalloonTipTitle = "Desktop Switched";
			notifyIcon1.BalloonTipText = string.Format("Current Desktop is {0}", (getCurrentDesktopIndex() + 1));
			notifyIcon1.ShowBalloonTip(0);
		}

		private void VirtualDesktop_Shortcuts()
		{
			
		}

		private void VirtualDesktop_SwitchByIndex(int idDesktop)
		{
			// Author: rootwo62
			try
			{
				VirtualDesktop[] vDesktops = VirtualDesktop.GetDesktops();
				vDesktops[idDesktop].Switch();
			}
			catch (Exception err)
			{
				Console.Write("[ERROR SWITCHING DESKTOPS] {0}", err.Message);
			}

		}

		// EVENT HANDLERS

		private void ToolStripItem_OnClick(object sender, EventArgs e)
		{
			var ToolStripItem = sender as ToolStripMenuItem;
			var ToolStripItemIndex = ToolStripItem.GetCurrentParent().Items.IndexOf(ToolStripItem);
			foreach (ToolStripMenuItem item in ToolStripItem.GetCurrentParent().Items)
			{
				if (item != ToolStripItem)
					item.Checked = false;
				else
					item.Checked = true;
			}

			Console.WriteLine("{0} was clicked, index = {1}", ToolStripItem.Text, ToolStripItemIndex);
            VirtualDesktop_SwitchByIndex(ToolStripItemIndex);
            ShowSplashVirtualDesktopSplashScreen();

        }

        // METHODS

        private void handleChangedNumber()
		{
			desktops = VirtualDesktop.GetDesktops();
			activePrograms = new IntPtr[desktops.Count];
		}

		private void NumberHotkeyPressed(object sender, KeyPressedEventArgs e)
		{
			var index = (int)e.HotKey.Key - (int)Key.D0 - 1;
			var currentDesktopIndex = getCurrentDesktopIndex();

			if (index == currentDesktopIndex)
			{
				return;
			}

			if (index > desktops.Count - 1)
			{
				return;
			}

			desktops.ElementAt(index)?.Switch();
			ShowSplashVirtualDesktopSplashScreen();
		}

		private void RegisterNumberHotkeys(ModifierKeys modifiers)
		{
			_numberHotkey.Register(Key.D1, modifiers);
			_numberHotkey.Register(Key.D2, modifiers);
			_numberHotkey.Register(Key.D3, modifiers);
			_numberHotkey.Register(Key.D4, modifiers);
			_numberHotkey.Register(Key.D5, modifiers);
			_numberHotkey.Register(Key.D6, modifiers);
			_numberHotkey.Register(Key.D7, modifiers);
			_numberHotkey.Register(Key.D8, modifiers);
			_numberHotkey.Register(Key.D9, modifiers);
		}

		private void normalHotkeys()
		{
			try
			{
				_rightHotkey.Register(Key.Right, System.Windows.Input.ModifierKeys.Control | System.Windows.Input.ModifierKeys.Alt);
				_leftHotkey.Register(Key.Left, System.Windows.Input.ModifierKeys.Control | System.Windows.Input.ModifierKeys.Alt);
				RegisterNumberHotkeys(System.Windows.Input.ModifierKeys.Control | System.Windows.Input.ModifierKeys.Alt);
			}
			catch (Exception err)
			{
				Console.WriteLine("[HOTKEY ERROR] {0}", err.Message);
				//notifyIcon1.BalloonTipTitle = "Error setting hotkeys";
				//notifyIcon1.BalloonTipText = "Could not set hotkeys. Please open settings and try the alternate combination.";
				//notifyIcon1.ShowBalloonTip(2000);
			}
		}

		private void alternateHotkeys()
		{
			try
			{
				_rightHotkey.Register(Key.Right, System.Windows.Input.ModifierKeys.Shift | System.Windows.Input.ModifierKeys.Alt);
				_leftHotkey.Register(Key.Left, System.Windows.Input.ModifierKeys.Shift | System.Windows.Input.ModifierKeys.Alt);
				RegisterNumberHotkeys(System.Windows.Input.ModifierKeys.Shift | System.Windows.Input.ModifierKeys.Alt);
			}
			catch (Exception err)
			{
				Console.WriteLine("[HOTKEY ERROR] {0}", err.Message);
				//notifyIcon1.BalloonTipTitle = "Error setting hotkeys";
				//notifyIcon1.BalloonTipText = "Could not set hotkeys. Please open settings and try the default combination.";
				//notifyIcon1.ShowBalloonTip(2000);
			}
		}

		private void openSettings()
		{
			this.Visible = true;
			this.WindowState = System.Windows.Forms.FormWindowState.Normal;
			this.ShowInTaskbar = true;
            this.TopMost = true;

        }

		private string PickNthFile(int currentDesktopIndex)
		{
			int n = Properties.Settings.Default.DesktopBackgroundFiles.Count;
			if (n == 0)
				return null;
			int index = currentDesktopIndex % n;
			return Properties.Settings.Default.DesktopBackgroundFiles[index];
		}

		void RightKeyManagerPressed(object sender, KeyPressedEventArgs e)
		{
			var desktop = initialDesktopState();

			if (desktop.GetRight() != null)
			{
				desktop.GetRight()?.Switch();
			}
			else
			{
				desktops.First()?.Switch();
			}
		}

		void LeftKeyManagerPressed(object sender, KeyPressedEventArgs e)
		{
			var desktop = initialDesktopState();

			if (desktop.GetLeft() != null)
			{
				desktop.GetLeft()?.Switch();
			}
			else
			{
				desktops.Last()?.Switch();
			}
		}

		private void saveApplicationFocus(int currentDesktopIndex = -1)
		{
			IntPtr activeAppWindow = GetForegroundWindow();

			if (currentDesktopIndex == -1)
				currentDesktopIndex = getCurrentDesktopIndex();

			activePrograms[currentDesktopIndex] = activeAppWindow;
		}

		private void restoreApplicationFocus(int currentDesktopIndex = -1)
		{
			if (currentDesktopIndex == -1)
				currentDesktopIndex = getCurrentDesktopIndex();

			if (activePrograms[currentDesktopIndex] != null && activePrograms[currentDesktopIndex] != IntPtr.Zero)
			{
				SetForegroundWindow(activePrograms[currentDesktopIndex]);
			}
		}

        // FUNCTIONS

        private static ListViewItem NewListViewItem(string file)
		{
			return new ListViewItem()
			{
				Text = Path.GetFileName(file),
				ToolTipText = file,
				Name = Path.GetFileName(file),
				Tag = file
			};
		}

		Form CurrentVirtualDesktopSplashScreen;

		Form currentVirtualDesktop(int vDesktopIndexx)
        {

            Font fontCurrentDesktop = new Font("Roboto", 24, FontStyle.Bold);
            Font fontCurrentDesktopIndex = new Font("Roboto", 128, FontStyle.Bold);

            Label labelCurrentDesktop = new Label();
            labelCurrentDesktop.Text = string.Format("Desktop");
            labelCurrentDesktop.Font = fontCurrentDesktop;
            labelCurrentDesktop.TextAlign = ContentAlignment.MiddleCenter;
            labelCurrentDesktop.AutoSize = false;
            labelCurrentDesktop.Height = 50;
            labelCurrentDesktop.ForeColor = Color.White;
            labelCurrentDesktop.Dock = DockStyle.Top;

            Label labelCurrentDesktopIndex = new Label();
            labelCurrentDesktopIndex.Text = (vDesktopIndexx + 1).ToString();
            labelCurrentDesktopIndex.Font = fontCurrentDesktopIndex;
            labelCurrentDesktopIndex.TextAlign = ContentAlignment.MiddleCenter;
            labelCurrentDesktopIndex.AutoSize = false;
			labelCurrentDesktopIndex.ForeColor = Color.White;
            labelCurrentDesktopIndex.Dock = DockStyle.Fill;

            Panel body = new Panel();
            body.Controls.Add(labelCurrentDesktop);
            body.Controls.Add(labelCurrentDesktopIndex);
            body.Dock = DockStyle.Fill;

			Form form = new Form();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Controls.Add(body);
            form.FormBorderStyle = FormBorderStyle.None;
			form.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, form.Width, form.Height, 20, 20));
			form.BackColor = ColorTranslator.FromHtml("#212121");
            form.Opacity = .5;
			form.ShowInTaskbar = false;
            form.TopMost = true;
            return form;
        }

		private void ShowSplashVirtualDesktopSplashScreen()
		{
			if (CurrentVirtualDesktopSplashScreen == null)
			{
				CurrentVirtualDesktopSplashScreen = currentVirtualDesktop(getCurrentDesktopIndex());
				CurrentVirtualDesktopSplashScreen.Focus();
				CurrentVirtualDesktopSplashScreen.Show();
				bwSplashTimer.RunWorkerAsync();
			}
		}

		private int getCurrentDesktopIndex()
		{
			return desktops.IndexOf(VirtualDesktop.Current);
		}

		// BACKGROUND WORKERS

		private BackgroundWorker bwCheckVirtualDesktop = new BackgroundWorker();

		private void bwCheckVirtualDesktop_DoWork(object sender, DoWorkEventArgs e)
		{
			do
			{
				Thread.Sleep(100);
				bwCheckVirtualDesktop.ReportProgress(getCurrentDesktopIndex());
			} while (true);
		}

		private void bwCheckVirtualDesktop_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			try
			{
			ToolStripMenuItem toolStripItemParent = contextMenuStrip1.Items["desktopsToolStripMenuItem"] as ToolStripMenuItem;
			foreach (ToolStripMenuItem item in toolStripItemParent.DropDownItems)
			{
				
					if (item != (toolStripItemParent.DropDownItems[e.ProgressPercentage] as ToolStripMenuItem))
						item.Checked = false;
					else
						item.Checked = true;
				}
			}
			catch (Exception err)
			{

				Console.WriteLine("[ERROR] {0}", err.Message);
			}
		}

        private BackgroundWorker bwSplashTimer = new BackgroundWorker();

        private void bwSplashTimer_DoWork(object sender, DoWorkEventArgs e)
        {
            int splashScreenInterval = 1750;
            int sleepTimer = 10;
            Console.WriteLine("timer started");
            Timers.Timer r = new Timers.Timer();
            r.Interval = splashScreenInterval;
            r.Enabled = true;

            int i = splashScreenInterval;

            while (i > 0)
            {
				Thread.Sleep(sleepTimer);
				i -= sleepTimer;
				bwSplashTimer.ReportProgress(i);
            }
        }

        private void bwSplashTimer_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            double opacitylevel = ((double)e.ProgressPercentage / 1000);
            Console.WriteLine(opacitylevel);
            CurrentVirtualDesktopSplashScreen.Opacity = opacitylevel;
        }

        private void bwSplashTimer_WorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CurrentVirtualDesktopSplashScreen.Close();
            CurrentVirtualDesktopSplashScreen.Dispose();
            CurrentVirtualDesktopSplashScreen = null;
        }

        // TESTING

		private void labelDebug_Click(object sender, EventArgs e)
		{
			
		}

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSplashVirtualDesktopSplashScreen();
        }
    }
}
