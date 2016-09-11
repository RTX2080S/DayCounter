namespace DayCounter
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.myNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.myContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showMainWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonHide = new System.Windows.Forms.Button();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.checkBoxSelfStart = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timerRefresher = new System.Windows.Forms.Timer(this.components);
            this.opacityBar = new System.Windows.Forms.TrackBar();
            this.checkBoxToday = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.myContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacityBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(16, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date 1: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(16, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date 2: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // myNotifyIcon
            // 
            this.myNotifyIcon.ContextMenuStrip = this.myContextMenuStrip;
            this.myNotifyIcon.Text = "notifyIcon1";
            this.myNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.myNotifyIcon_MouseDoubleClick);
            // 
            // myContextMenuStrip
            // 
            this.myContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMainWindowToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.myContextMenuStrip.Name = "myContextMenuStrip";
            this.myContextMenuStrip.Size = new System.Drawing.Size(179, 70);
            // 
            // showMainWindowToolStripMenuItem
            // 
            this.showMainWindowToolStripMenuItem.Name = "showMainWindowToolStripMenuItem";
            this.showMainWindowToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.showMainWindowToolStripMenuItem.Text = "Show main window";
            this.showMainWindowToolStripMenuItem.Click += new System.EventHandler(this.showMainWindowToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(471, 81);
            this.label3.TabIndex = 4;
            this.label3.Text = "Here goes the result";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.GreenYellow;
            this.buttonExit.Location = new System.Drawing.Point(260, 3);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 31);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonHide
            // 
            this.buttonHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHide.BackColor = System.Drawing.Color.Transparent;
            this.buttonHide.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHide.ForeColor = System.Drawing.Color.GreenYellow;
            this.buttonHide.Location = new System.Drawing.Point(368, 3);
            this.buttonHide.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(100, 31);
            this.buttonHide.TabIndex = 8;
            this.buttonHide.Text = "Minimize";
            this.buttonHide.UseVisualStyleBackColor = false;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // myTimer
            // 
            this.myTimer.Enabled = true;
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // checkBoxSelfStart
            // 
            this.checkBoxSelfStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxSelfStart.AutoSize = true;
            this.checkBoxSelfStart.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxSelfStart.ForeColor = System.Drawing.Color.GreenYellow;
            this.checkBoxSelfStart.Location = new System.Drawing.Point(12, 9);
            this.checkBoxSelfStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxSelfStart.Name = "checkBoxSelfStart";
            this.checkBoxSelfStart.Size = new System.Drawing.Size(89, 21);
            this.checkBoxSelfStart.TabIndex = 9;
            this.checkBoxSelfStart.Text = "Auto start";
            this.checkBoxSelfStart.UseVisualStyleBackColor = false;
            this.checkBoxSelfStart.CheckedChanged += new System.EventHandler(this.checkBoxSelfStart_CheckedChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.LawnGreen;
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 48);
            this.label4.TabIndex = 11;
            this.label4.Text = "Opacity: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerRefresher
            // 
            this.timerRefresher.Interval = 980;
            this.timerRefresher.Tick += new System.EventHandler(this.timerRefresher_Tick);
            // 
            // opacityBar
            // 
            this.opacityBar.BackColor = System.Drawing.Color.MidnightBlue;
            this.opacityBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::DayCounter.Properties.Settings.Default, "opacityBarValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.opacityBar.Location = new System.Drawing.Point(93, 12);
            this.opacityBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.opacityBar.Maximum = 100;
            this.opacityBar.Minimum = 5;
            this.opacityBar.Name = "opacityBar";
            this.opacityBar.Size = new System.Drawing.Size(390, 45);
            this.opacityBar.TabIndex = 10;
            this.opacityBar.Value = global::DayCounter.Properties.Settings.Default.opacityBarValue;
            this.opacityBar.Scroll += new System.EventHandler(this.opacityBar_Scroll);
            // 
            // checkBoxToday
            // 
            this.checkBoxToday.AutoSize = true;
            this.checkBoxToday.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxToday.Checked = global::DayCounter.Properties.Settings.Default.UseToday;
            this.checkBoxToday.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DayCounter.Properties.Settings.Default, "UseToday", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxToday.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxToday.Location = new System.Drawing.Point(326, 92);
            this.checkBoxToday.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxToday.Name = "checkBoxToday";
            this.checkBoxToday.Size = new System.Drawing.Size(157, 21);
            this.checkBoxToday.TabIndex = 6;
            this.checkBoxToday.Text = "Use Today for Date 1";
            this.checkBoxToday.UseVisualStyleBackColor = false;
            this.checkBoxToday.CheckedChanged += new System.EventHandler(this.checkBoxToday_CheckedChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::DayCounter.Properties.Settings.Default, "Date2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateTimePicker2.Location = new System.Drawing.Point(93, 119);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(390, 23);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.Value = global::DayCounter.Properties.Settings.Default.Date2;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::DayCounter.Properties.Settings.Default, "Date1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateTimePicker1.Location = new System.Drawing.Point(93, 66);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(390, 23);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = global::DayCounter.Properties.Settings.Default.Date1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.checkBoxSelfStart);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonHide);
            this.panel1.Location = new System.Drawing.Point(12, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 40);
            this.panel1.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DayCounter.Properties.Resources.img103;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.buttonHide;
            this.ClientSize = new System.Drawing.Size(496, 281);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.opacityBar);
            this.Controls.Add(this.checkBoxToday);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(512, 320);
            this.MinimumSize = new System.Drawing.Size(512, 320);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Art of Waiting";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.myContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.opacityBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ContextMenuStrip myContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxToday;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.Timer myTimer;
        private System.Windows.Forms.CheckBox checkBoxSelfStart;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMainWindowToolStripMenuItem;
        public System.Windows.Forms.NotifyIcon myNotifyIcon;
        private System.Windows.Forms.TrackBar opacityBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timerRefresher;
        private System.Windows.Forms.Panel panel1;
    }
}
