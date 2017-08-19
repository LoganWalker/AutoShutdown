namespace MultifunctionApp
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
            this.rdobtnTestModeFast = new System.Windows.Forms.RadioButton();
            this.rdobtnTestModeNorm = new System.Windows.Forms.RadioButton();
            this.Safety = new System.Windows.Forms.Label();
            this.gbxSAFE = new System.Windows.Forms.GroupBox();
            this.rdobtnSafeON = new System.Windows.Forms.RadioButton();
            this.rdobtnSafeOFF = new System.Windows.Forms.RadioButton();
            this.lblCustomInfo = new System.Windows.Forms.Label();
            this.lblTimerInfo = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSetTimer = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtCustomTime = new System.Windows.Forms.TextBox();
            this.gbTime = new System.Windows.Forms.GroupBox();
            this.rdoCustomTime = new System.Windows.Forms.RadioButton();
            this.rdobtn1Min = new System.Windows.Forms.RadioButton();
            this.rdobtn5Mins = new System.Windows.Forms.RadioButton();
            this.rdobtn30Sec = new System.Windows.Forms.RadioButton();
            this.rdobtn10Sec = new System.Windows.Forms.RadioButton();
            this.btnOption = new System.Windows.Forms.Button();
            this.gpbox = new System.Windows.Forms.GroupBox();
            this.rdobtnStop = new System.Windows.Forms.RadioButton();
            this.rdobtnHibinate = new System.Windows.Forms.RadioButton();
            this.rdobtnSleep = new System.Windows.Forms.RadioButton();
            this.rdobtnLock = new System.Windows.Forms.RadioButton();
            this.rdobtnLogOff = new System.Windows.Forms.RadioButton();
            this.rdobtnShutdown = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsProgBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tsProgDone = new System.Windows.Forms.ToolStripStatusLabel();
            this.OptionTimer = new System.Windows.Forms.Timer(this.components);
            this.gbMContent = new System.Windows.Forms.GroupBox();
            this.gbSpeed = new System.Windows.Forms.GroupBox();
            this.gbShowTime = new System.Windows.Forms.GroupBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsUserFeedback = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.gbUpdates = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PopUpLable = new System.Windows.Forms.Label();
            this.lblTimeLbl = new System.Windows.Forms.Label();
            this.DateTime = new System.Windows.Forms.Timer(this.components);
            this.gbxSAFE.SuspendLayout();
            this.gbTime.SuspendLayout();
            this.gpbox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gbMContent.SuspendLayout();
            this.gbSpeed.SuspendLayout();
            this.gbShowTime.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbUpdates.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdobtnTestModeFast
            // 
            this.rdobtnTestModeFast.AutoSize = true;
            this.rdobtnTestModeFast.Location = new System.Drawing.Point(6, 42);
            this.rdobtnTestModeFast.Name = "rdobtnTestModeFast";
            this.rdobtnTestModeFast.Size = new System.Drawing.Size(75, 17);
            this.rdobtnTestModeFast.TabIndex = 2;
            this.rdobtnTestModeFast.Text = "Fast Mode";
            this.rdobtnTestModeFast.UseVisualStyleBackColor = true;
            // 
            // rdobtnTestModeNorm
            // 
            this.rdobtnTestModeNorm.AutoSize = true;
            this.rdobtnTestModeNorm.Checked = true;
            this.rdobtnTestModeNorm.Location = new System.Drawing.Point(6, 19);
            this.rdobtnTestModeNorm.Name = "rdobtnTestModeNorm";
            this.rdobtnTestModeNorm.Size = new System.Drawing.Size(88, 17);
            this.rdobtnTestModeNorm.TabIndex = 1;
            this.rdobtnTestModeNorm.TabStop = true;
            this.rdobtnTestModeNorm.Text = "Normal Mode";
            this.rdobtnTestModeNorm.UseVisualStyleBackColor = true;
            // 
            // Safety
            // 
            this.Safety.AutoSize = true;
            this.Safety.Location = new System.Drawing.Point(99, 16);
            this.Safety.Name = "Safety";
            this.Safety.Size = new System.Drawing.Size(87, 13);
            this.Safety.TabIndex = 0;
            this.Safety.Text = "Safe Mode: [ON]";
            // 
            // gbxSAFE
            // 
            this.gbxSAFE.Controls.Add(this.rdobtnSafeON);
            this.gbxSAFE.Controls.Add(this.rdobtnSafeOFF);
            this.gbxSAFE.Location = new System.Drawing.Point(522, 69);
            this.gbxSAFE.Name = "gbxSAFE";
            this.gbxSAFE.Size = new System.Drawing.Size(96, 67);
            this.gbxSAFE.TabIndex = 4;
            this.gbxSAFE.TabStop = false;
            this.gbxSAFE.Text = "Safe Mode";
            // 
            // rdobtnSafeON
            // 
            this.rdobtnSafeON.AutoSize = true;
            this.rdobtnSafeON.Checked = true;
            this.rdobtnSafeON.Location = new System.Drawing.Point(6, 19);
            this.rdobtnSafeON.Name = "rdobtnSafeON";
            this.rdobtnSafeON.Size = new System.Drawing.Size(39, 17);
            this.rdobtnSafeON.TabIndex = 1;
            this.rdobtnSafeON.TabStop = true;
            this.rdobtnSafeON.Text = "On";
            this.rdobtnSafeON.UseVisualStyleBackColor = true;
            this.rdobtnSafeON.CheckedChanged += new System.EventHandler(this.rdobtnSafeON_CheckedChanged);
            // 
            // rdobtnSafeOFF
            // 
            this.rdobtnSafeOFF.AutoSize = true;
            this.rdobtnSafeOFF.Location = new System.Drawing.Point(6, 42);
            this.rdobtnSafeOFF.Name = "rdobtnSafeOFF";
            this.rdobtnSafeOFF.Size = new System.Drawing.Size(39, 17);
            this.rdobtnSafeOFF.TabIndex = 2;
            this.rdobtnSafeOFF.Text = "Off";
            this.rdobtnSafeOFF.UseVisualStyleBackColor = true;
            this.rdobtnSafeOFF.CheckedChanged += new System.EventHandler(this.rdobtnSafeOFF_CheckedChanged);
            // 
            // lblCustomInfo
            // 
            this.lblCustomInfo.AutoSize = true;
            this.lblCustomInfo.Location = new System.Drawing.Point(19, 42);
            this.lblCustomInfo.Name = "lblCustomInfo";
            this.lblCustomInfo.Size = new System.Drawing.Size(159, 13);
            this.lblCustomInfo.TabIndex = 0;
            this.lblCustomInfo.Text = "Enter Custom Time (In Seconds)";
            // 
            // lblTimerInfo
            // 
            this.lblTimerInfo.AutoSize = true;
            this.lblTimerInfo.Location = new System.Drawing.Point(159, 20);
            this.lblTimerInfo.Name = "lblTimerInfo";
            this.lblTimerInfo.Size = new System.Drawing.Size(33, 13);
            this.lblTimerInfo.TabIndex = 0;
            this.lblTimerInfo.Text = "Time:";
            this.lblTimerInfo.Visible = false;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(96, 84);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(86, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop Timer";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSetTimer
            // 
            this.btnSetTimer.Location = new System.Drawing.Point(11, 84);
            this.btnSetTimer.Name = "btnSetTimer";
            this.btnSetTimer.Size = new System.Drawing.Size(86, 23);
            this.btnSetTimer.TabIndex = 4;
            this.btnSetTimer.Text = "Start Timer";
            this.btnSetTimer.UseVisualStyleBackColor = true;
            this.btnSetTimer.Click += new System.EventHandler(this.btnSetTimer_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(12, 16);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(58, 13);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "0 Seconds";
            // 
            // txtCustomTime
            // 
            this.txtCustomTime.Enabled = false;
            this.txtCustomTime.Location = new System.Drawing.Point(11, 58);
            this.txtCustomTime.Name = "txtCustomTime";
            this.txtCustomTime.Size = new System.Drawing.Size(171, 20);
            this.txtCustomTime.TabIndex = 3;
            this.txtCustomTime.Text = "0";
            this.txtCustomTime.TextChanged += new System.EventHandler(this.txtCustomTime_TextChanged);
            this.txtCustomTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomTime_KeyDown);
            this.txtCustomTime.Leave += new System.EventHandler(this.txtCustomTime_Leave);
            // 
            // gbTime
            // 
            this.gbTime.Controls.Add(this.rdoCustomTime);
            this.gbTime.Controls.Add(this.rdobtn1Min);
            this.gbTime.Controls.Add(this.rdobtn5Mins);
            this.gbTime.Controls.Add(this.rdobtn30Sec);
            this.gbTime.Controls.Add(this.rdobtn10Sec);
            this.gbTime.Location = new System.Drawing.Point(318, 27);
            this.gbTime.Name = "gbTime";
            this.gbTime.Size = new System.Drawing.Size(96, 130);
            this.gbTime.TabIndex = 3;
            this.gbTime.TabStop = false;
            this.gbTime.Text = "Timer Options";
            // 
            // rdoCustomTime
            // 
            this.rdoCustomTime.AutoSize = true;
            this.rdoCustomTime.Location = new System.Drawing.Point(6, 111);
            this.rdoCustomTime.Name = "rdoCustomTime";
            this.rdoCustomTime.Size = new System.Drawing.Size(86, 17);
            this.rdoCustomTime.TabIndex = 10;
            this.rdoCustomTime.Text = "Custom Time";
            this.rdoCustomTime.UseVisualStyleBackColor = true;
            this.rdoCustomTime.CheckedChanged += new System.EventHandler(this.rdoCustomTime_CheckedChanged);
            // 
            // rdobtn1Min
            // 
            this.rdobtn1Min.AutoSize = true;
            this.rdobtn1Min.Location = new System.Drawing.Point(6, 65);
            this.rdobtn1Min.Name = "rdobtn1Min";
            this.rdobtn1Min.Size = new System.Drawing.Size(66, 17);
            this.rdobtn1Min.TabIndex = 8;
            this.rdobtn1Min.Text = "1 Minute";
            this.rdobtn1Min.UseVisualStyleBackColor = true;
            this.rdobtn1Min.CheckedChanged += new System.EventHandler(this.rdobtn1Min_CheckedChanged);
            // 
            // rdobtn5Mins
            // 
            this.rdobtn5Mins.AutoSize = true;
            this.rdobtn5Mins.Location = new System.Drawing.Point(6, 88);
            this.rdobtn5Mins.Name = "rdobtn5Mins";
            this.rdobtn5Mins.Size = new System.Drawing.Size(71, 17);
            this.rdobtn5Mins.TabIndex = 9;
            this.rdobtn5Mins.Text = "5 Minutes";
            this.rdobtn5Mins.UseVisualStyleBackColor = true;
            this.rdobtn5Mins.CheckedChanged += new System.EventHandler(this.rdobtn5Mins_CheckedChanged);
            // 
            // rdobtn30Sec
            // 
            this.rdobtn30Sec.AutoSize = true;
            this.rdobtn30Sec.Location = new System.Drawing.Point(6, 42);
            this.rdobtn30Sec.Name = "rdobtn30Sec";
            this.rdobtn30Sec.Size = new System.Drawing.Size(82, 17);
            this.rdobtn30Sec.TabIndex = 7;
            this.rdobtn30Sec.Text = "30 Seconds";
            this.rdobtn30Sec.UseVisualStyleBackColor = true;
            this.rdobtn30Sec.CheckedChanged += new System.EventHandler(this.rdobtn30Sec_CheckedChanged);
            // 
            // rdobtn10Sec
            // 
            this.rdobtn10Sec.AutoSize = true;
            this.rdobtn10Sec.Checked = true;
            this.rdobtn10Sec.Location = new System.Drawing.Point(6, 19);
            this.rdobtn10Sec.Name = "rdobtn10Sec";
            this.rdobtn10Sec.Size = new System.Drawing.Size(82, 17);
            this.rdobtn10Sec.TabIndex = 6;
            this.rdobtn10Sec.TabStop = true;
            this.rdobtn10Sec.Text = "10 Seconds";
            this.rdobtn10Sec.UseVisualStyleBackColor = true;
            this.rdobtn10Sec.CheckedChanged += new System.EventHandler(this.rdobtn10Sec_CheckedChanged);
            // 
            // btnOption
            // 
            this.btnOption.Location = new System.Drawing.Point(11, 113);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(171, 23);
            this.btnOption.TabIndex = 6;
            this.btnOption.Text = "Instant Lock";
            this.btnOption.UseVisualStyleBackColor = true;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // gpbox
            // 
            this.gpbox.Controls.Add(this.rdobtnStop);
            this.gpbox.Controls.Add(this.rdobtnHibinate);
            this.gpbox.Controls.Add(this.rdobtnSleep);
            this.gpbox.Controls.Add(this.rdobtnLock);
            this.gpbox.Controls.Add(this.rdobtnLogOff);
            this.gpbox.Controls.Add(this.rdobtnShutdown);
            this.gpbox.Location = new System.Drawing.Point(216, 27);
            this.gpbox.Name = "gpbox";
            this.gpbox.Size = new System.Drawing.Size(96, 149);
            this.gpbox.TabIndex = 2;
            this.gpbox.TabStop = false;
            this.gpbox.Text = "Options";
            // 
            // rdobtnStop
            // 
            this.rdobtnStop.AutoSize = true;
            this.rdobtnStop.Location = new System.Drawing.Point(6, 130);
            this.rdobtnStop.Name = "rdobtnStop";
            this.rdobtnStop.Size = new System.Drawing.Size(59, 17);
            this.rdobtnStop.TabIndex = 7;
            this.rdobtnStop.Text = "Restart";
            this.rdobtnStop.UseVisualStyleBackColor = true;
            this.rdobtnStop.CheckedChanged += new System.EventHandler(this.rdobtnStop_CheckedChanged);
            // 
            // rdobtnHibinate
            // 
            this.rdobtnHibinate.AutoSize = true;
            this.rdobtnHibinate.Location = new System.Drawing.Point(6, 86);
            this.rdobtnHibinate.Name = "rdobtnHibinate";
            this.rdobtnHibinate.Size = new System.Drawing.Size(71, 17);
            this.rdobtnHibinate.TabIndex = 5;
            this.rdobtnHibinate.Text = "Hibernate";
            this.rdobtnHibinate.UseVisualStyleBackColor = true;
            this.rdobtnHibinate.CheckedChanged += new System.EventHandler(this.rdobtnHibinate_CheckedChanged);
            // 
            // rdobtnSleep
            // 
            this.rdobtnSleep.AutoSize = true;
            this.rdobtnSleep.Location = new System.Drawing.Point(6, 63);
            this.rdobtnSleep.Name = "rdobtnSleep";
            this.rdobtnSleep.Size = new System.Drawing.Size(52, 17);
            this.rdobtnSleep.TabIndex = 4;
            this.rdobtnSleep.Text = "Sleep";
            this.rdobtnSleep.UseVisualStyleBackColor = true;
            this.rdobtnSleep.CheckedChanged += new System.EventHandler(this.rdobtnSleep_CheckedChanged);
            // 
            // rdobtnLock
            // 
            this.rdobtnLock.AutoSize = true;
            this.rdobtnLock.Checked = true;
            this.rdobtnLock.Location = new System.Drawing.Point(6, 19);
            this.rdobtnLock.Name = "rdobtnLock";
            this.rdobtnLock.Size = new System.Drawing.Size(49, 17);
            this.rdobtnLock.TabIndex = 1;
            this.rdobtnLock.TabStop = true;
            this.rdobtnLock.Text = "Lock";
            this.rdobtnLock.UseVisualStyleBackColor = true;
            this.rdobtnLock.CheckedChanged += new System.EventHandler(this.rdobtnLock_CheckedChanged);
            // 
            // rdobtnLogOff
            // 
            this.rdobtnLogOff.AutoSize = true;
            this.rdobtnLogOff.Location = new System.Drawing.Point(6, 42);
            this.rdobtnLogOff.Name = "rdobtnLogOff";
            this.rdobtnLogOff.Size = new System.Drawing.Size(60, 17);
            this.rdobtnLogOff.TabIndex = 2;
            this.rdobtnLogOff.Text = "Log Off";
            this.rdobtnLogOff.UseVisualStyleBackColor = true;
            this.rdobtnLogOff.CheckedChanged += new System.EventHandler(this.rdobtnLogOff_CheckedChanged);
            // 
            // rdobtnShutdown
            // 
            this.rdobtnShutdown.AutoSize = true;
            this.rdobtnShutdown.Location = new System.Drawing.Point(6, 109);
            this.rdobtnShutdown.Name = "rdobtnShutdown";
            this.rdobtnShutdown.Size = new System.Drawing.Size(73, 17);
            this.rdobtnShutdown.TabIndex = 6;
            this.rdobtnShutdown.Text = "Shutdown";
            this.rdobtnShutdown.UseVisualStyleBackColor = true;
            this.rdobtnShutdown.CheckedChanged += new System.EventHandler(this.rdobtnShutdown_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMessage,
            this.tsProgBar,
            this.tsProgDone});
            this.statusStrip1.Location = new System.Drawing.Point(0, 189);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(624, 22);
            this.statusStrip1.TabIndex = 36;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsMessage
            // 
            this.tsMessage.Name = "tsMessage";
            this.tsMessage.Size = new System.Drawing.Size(39, 17);
            this.tsMessage.Text = "Ready";
            // 
            // tsProgBar
            // 
            this.tsProgBar.Name = "tsProgBar";
            this.tsProgBar.RightToLeftLayout = true;
            this.tsProgBar.Size = new System.Drawing.Size(135, 16);
            // 
            // tsProgDone
            // 
            this.tsProgDone.Name = "tsProgDone";
            this.tsProgDone.Size = new System.Drawing.Size(23, 17);
            this.tsProgDone.Text = "0%";
            // 
            // OptionTimer
            // 
            this.OptionTimer.Interval = 1000;
            this.OptionTimer.Tick += new System.EventHandler(this.OptionTimer_Tick);
            // 
            // gbMContent
            // 
            this.gbMContent.Controls.Add(this.Safety);
            this.gbMContent.Controls.Add(this.txtCustomTime);
            this.gbMContent.Controls.Add(this.lblCustomInfo);
            this.gbMContent.Controls.Add(this.btnOption);
            this.gbMContent.Controls.Add(this.btnSetTimer);
            this.gbMContent.Controls.Add(this.btnStop);
            this.gbMContent.Location = new System.Drawing.Point(12, 27);
            this.gbMContent.Name = "gbMContent";
            this.gbMContent.Size = new System.Drawing.Size(198, 149);
            this.gbMContent.TabIndex = 1;
            this.gbMContent.TabStop = false;
            this.gbMContent.Text = "Main Content";
            // 
            // gbSpeed
            // 
            this.gbSpeed.Controls.Add(this.rdobtnTestModeNorm);
            this.gbSpeed.Controls.Add(this.rdobtnTestModeFast);
            this.gbSpeed.Location = new System.Drawing.Point(420, 69);
            this.gbSpeed.Name = "gbSpeed";
            this.gbSpeed.Size = new System.Drawing.Size(96, 67);
            this.gbSpeed.TabIndex = 5;
            this.gbSpeed.TabStop = false;
            this.gbSpeed.Text = "Speed";
            // 
            // gbShowTime
            // 
            this.gbShowTime.Controls.Add(this.lblTimerInfo);
            this.gbShowTime.Controls.Add(this.lblTime);
            this.gbShowTime.Location = new System.Drawing.Point(420, 27);
            this.gbShowTime.Name = "gbShowTime";
            this.gbShowTime.Size = new System.Drawing.Size(198, 36);
            this.gbShowTime.TabIndex = 37;
            this.gbShowTime.TabStop = false;
            this.gbShowTime.Text = "Time";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "RANDOM TEST? ";
            this.notifyIcon1.BalloonTipTitle = "dsfsdfsdf";
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOptions,
            this.tsUserFeedback,
            this.toolStripSeparator5,
            this.tsAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // tsOptions
            // 
            this.tsOptions.Name = "tsOptions";
            this.tsOptions.Size = new System.Drawing.Size(150, 22);
            this.tsOptions.Text = "Options";
            this.tsOptions.Click += new System.EventHandler(this.tsOptions_Click);
            // 
            // tsUserFeedback
            // 
            this.tsUserFeedback.Name = "tsUserFeedback";
            this.tsUserFeedback.Size = new System.Drawing.Size(150, 22);
            this.tsUserFeedback.Text = "&User Feedback";
            this.tsUserFeedback.Click += new System.EventHandler(this.tsUserFeedback_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(147, 6);
            // 
            // tsAbout
            // 
            this.tsAbout.Name = "tsAbout";
            this.tsAbout.Size = new System.Drawing.Size(150, 22);
            this.tsAbout.Text = "&About";
            this.tsAbout.Click += new System.EventHandler(this.tsAbout_Click);
            // 
            // gbUpdates
            // 
            this.gbUpdates.Controls.Add(this.label1);
            this.gbUpdates.Location = new System.Drawing.Point(420, 142);
            this.gbUpdates.Name = "gbUpdates";
            this.gbUpdates.Size = new System.Drawing.Size(198, 44);
            this.gbUpdates.TabIndex = 39;
            this.gbUpdates.TabStop = false;
            this.gbUpdates.Text = "Lastest News!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Time: ";
            // 
            // PopUpLable
            // 
            this.PopUpLable.AutoSize = true;
            this.PopUpLable.Location = new System.Drawing.Point(240, 177);
            this.PopUpLable.Name = "PopUpLable";
            this.PopUpLable.Size = new System.Drawing.Size(31, 13);
            this.PopUpLable.TabIndex = 40;
            this.PopUpLable.Text = "Lock";
            this.PopUpLable.Visible = false;
            // 
            // lblTimeLbl
            // 
            this.lblTimeLbl.AutoSize = true;
            this.lblTimeLbl.Location = new System.Drawing.Point(326, 176);
            this.lblTimeLbl.Name = "lblTimeLbl";
            this.lblTimeLbl.Size = new System.Drawing.Size(64, 13);
            this.lblTimeLbl.TabIndex = 41;
            this.lblTimeLbl.Text = "10 Seconds";
            this.lblTimeLbl.Visible = false;
            // 
            // DateTime
            // 
            this.DateTime.Enabled = true;
            this.DateTime.Interval = 1000;
            this.DateTime.Tick += new System.EventHandler(this.DateTime_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 211);
            this.Controls.Add(this.lblTimeLbl);
            this.Controls.Add(this.PopUpLable);
            this.Controls.Add(this.gbShowTime);
            this.Controls.Add(this.gbSpeed);
            this.Controls.Add(this.gbMContent);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbxSAFE);
            this.Controls.Add(this.gbTime);
            this.Controls.Add(this.gpbox);
            this.Controls.Add(this.gbUpdates);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(640, 250);
            this.MinimumSize = new System.Drawing.Size(640, 250);
            this.Name = "MainForm";
            this.Text = "Multifunction Tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbxSAFE.ResumeLayout(false);
            this.gbxSAFE.PerformLayout();
            this.gbTime.ResumeLayout(false);
            this.gbTime.PerformLayout();
            this.gpbox.ResumeLayout(false);
            this.gpbox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbMContent.ResumeLayout(false);
            this.gbMContent.PerformLayout();
            this.gbSpeed.ResumeLayout(false);
            this.gbSpeed.PerformLayout();
            this.gbShowTime.ResumeLayout(false);
            this.gbShowTime.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbUpdates.ResumeLayout(false);
            this.gbUpdates.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdobtnTestModeFast;
        private System.Windows.Forms.RadioButton rdobtnTestModeNorm;
        private System.Windows.Forms.Label Safety;
        private System.Windows.Forms.GroupBox gbxSAFE;
        private System.Windows.Forms.RadioButton rdobtnSafeON;
        private System.Windows.Forms.RadioButton rdobtnSafeOFF;
        private System.Windows.Forms.Label lblCustomInfo;
        private System.Windows.Forms.Label lblTimerInfo;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSetTimer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtCustomTime;
        private System.Windows.Forms.GroupBox gbTime;
        private System.Windows.Forms.RadioButton rdobtn1Min;
        private System.Windows.Forms.RadioButton rdobtn5Mins;
        private System.Windows.Forms.RadioButton rdobtn30Sec;
        private System.Windows.Forms.RadioButton rdobtn10Sec;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.GroupBox gpbox;
        private System.Windows.Forms.RadioButton rdobtnHibinate;
        private System.Windows.Forms.RadioButton rdobtnSleep;
        private System.Windows.Forms.RadioButton rdobtnLogOff;
        private System.Windows.Forms.RadioButton rdobtnStop;
        private System.Windows.Forms.RadioButton rdobtnLock;
        private System.Windows.Forms.RadioButton rdobtnShutdown;
        private System.Windows.Forms.RadioButton rdoCustomTime;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsMessage;
        private System.Windows.Forms.Timer OptionTimer;
        private System.Windows.Forms.ToolStripProgressBar tsProgBar;
        private System.Windows.Forms.GroupBox gbMContent;
        private System.Windows.Forms.GroupBox gbSpeed;
        private System.Windows.Forms.GroupBox gbShowTime;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsOptions;
        private System.Windows.Forms.ToolStripMenuItem tsUserFeedback;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsAbout;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbUpdates;
        private System.Windows.Forms.Label PopUpLable;
        private System.Windows.Forms.Label lblTimeLbl;
        private System.Windows.Forms.ToolStripStatusLabel tsProgDone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer DateTime;
    }
}

