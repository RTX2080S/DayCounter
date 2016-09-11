using DayCounter.Controllers;
using DayCounter.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DayCounter
{
    public partial class MainWindow : Form
    {

        #region Registry

        private IRegistryController myRegistry;

        private const string localMachineRegistryPath = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
        private const string currentUserRegistryPath = "HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

        private void checkBoxSelfStart_CheckedChanged(object sender, EventArgs e)
        {
            string updateMessage = string.Empty;

            bool updateSuccessful = (checkBoxSelfStart.Checked) ?
                myRegistry.Save(currentUserRegistryPath, ProductName, Application.ExecutablePath, out updateMessage) :
                myRegistry.Save(currentUserRegistryPath, ProductName, "Unavailable", out updateMessage);

            checkBoxSelfStart.Checked = isAutoStart();

            if (!updateSuccessful)
                MessageBox.Show(this, "Cannot write to the registry! " + updateMessage, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool isAutoStart()
        {
            return ((string)myRegistry.Get(currentUserRegistryPath, ProductName, "") == Application.ExecutablePath);
        }

        #endregion

        #region flashingColor

        public const int minR = 0;
        public const int maxR = 255;
        public const int rInc = 5;
        public int r = minR;
        public bool forward = true;

        public int getFlashingInterval(int r)
        {
            if (r <= 150) return (15);
            if ((r > 150) || (r <= 225)) return (25);
            if (r > 225) return (90);
            return (100);
        }

        public void refreshFlashingParams(ref int interval, ref Color itemColor)
        {
            if (forward) r += rInc; else r -= rInc;
            interval = getFlashingInterval(r);
            itemColor = Color.FromArgb(r, 0, 0);
            if (r == maxR) forward = false;
            if (r == minR) forward = true;
        }

        #endregion

        public MainWindow()
        {
            InitializeComponent();
            myRegistry = new RegistryController();
        }

        private void initializeUI()
        {
            myNotifyIcon.Icon = this.Icon = Properties.Resources.AppIcon;
            myNotifyIcon.MouseDoubleClick += myNotifyIcon_MouseDoubleClick;
            if (checkBoxToday.Checked) dateTimePicker1.Value = DateTime.Now;
            timerRefresher.Enabled = checkBoxToday.Checked;
            checkBoxSelfStart.Checked = isAutoStart();
            refreshOpacity();
            refreshAns();
        }

        private void myNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            toWindow();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            initializeUI();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!flagApp)
            {
                e.Cancel = true;
                toNotificationArea();
            }
        }

        private void toNotificationArea()
        {
            myNotifyIcon.Visible = true;
            this.Hide();
        }

        private void toWindow()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            myNotifyIcon.Visible = false;
        }

        private bool flagApp = false;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitMe();
        }

        private void exitMe()
        {
            Properties.Settings.Default.Save();
            flagApp = true;
            this.Close();
        }

        public string resultStr()
        {
            DateTime t1 = (checkBoxToday.Checked) ? DateTime.Now : dateTimePicker1.Value;
            DateTime t2 = dateTimePicker2.Value;
            TimeSpan t = t2 - t1;
            int dd = t.Days;
            int hh = t.Hours % 24;
            int mm = t.Minutes % 60;
            int ss = t.Seconds % 60;
            string ans = (checkBoxToday.Checked) ? string.Format("{0} days {1} hours {2} minutes {3} seconds to go! ", dd, hh, mm, ss)
                                                 : string.Format("{0} days to go! ", dd);
            return (ans);
        }

        private void refreshAns()
        {
            myNotifyIcon.Text = label3.Text = resultStr();
            Properties.Settings.Default.Save();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            exitMe();
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            toNotificationArea();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            toNotificationArea();
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            int tmpInterval = 0;
            Color tmpColor = Color.Red;
            refreshFlashingParams(ref tmpInterval, ref tmpColor);
            myTimer.Interval = tmpInterval;
            label3.ForeColor = tmpColor;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            refreshAns();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            refreshAns();
        }
        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show(this, "The Art of Waiting \n\n By Steven LL \n\n Alien Laboratory",
                        ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void showMainWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toWindow();
        }

        private void opacityBar_Scroll(object sender, EventArgs e)
        {
            refreshOpacity();
        }

        private void refreshOpacity()
        {
            this.Opacity = (opacityBar.Value / 100.0);
        }


        private void checkBoxToday_CheckedChanged(object sender, EventArgs e)
        {
            timerRefresher.Enabled = checkBoxToday.Checked;
            refreshAns();
        }

        private void timerRefresher_Tick(object sender, EventArgs e)
        {
            refreshAns();
        }

    }
}
