using Alienlab.WinForm.API;
using DayCounter.Controllers;
using DayCounter.Interfaces;
using System;
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
        
        public MainWindow()
        {
            InitializeComponent();
            myRegistry = new RegistryController();
        }

        private void initializeUI()
        {
            var flashingLabel = new AviationObstructionLight();
            flashingLabel.ApplyToLabel(label3);
            
            myNotifyIcon.Icon = Icon = Properties.Resources.AppIcon;
            myNotifyIcon.MouseDoubleClick += myNotifyIcon_MouseDoubleClick;

            if (checkBoxToday.Checked)
                dateTimePicker1.Value = DateTime.Now;

            timerRefresher.Enabled = checkBoxToday.Checked;
            checkBoxSelfStart.Checked = isAutoStart();

            refreshOpacity();
            refreshAnswer();
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
            Hide();
        }

        private void toWindow()
        {
            Show();
            WindowState = FormWindowState.Normal;
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
            Close();
        }
        
        private void refreshAnswer()
        {
            ICore core = new Core(checkBoxToday.Checked, dateTimePicker1.Value, dateTimePicker2.Value);
            myNotifyIcon.Text = label3.Text = core.GetResult();
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
        
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            refreshAnswer();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            refreshAnswer();
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
            Opacity = (opacityBar.Value / 100.0);
        }
        
        private void checkBoxToday_CheckedChanged(object sender, EventArgs e)
        {
            timerRefresher.Enabled = checkBoxToday.Checked;
            refreshAnswer();
        }

        private void timerRefresher_Tick(object sender, EventArgs e)
        {
            refreshAnswer();
        }

    }
}
