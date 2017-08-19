using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Net;
using System.Net.Mail;


//http://stackoverflow.com/questions/11165537/passing-textboxs-text-to-another-form-in-c
///////////////////////////
// Logan AD Walker
// Jan - Mar - 2014
///////////////////////////

namespace MultifunctionApp
{
    public partial class MainForm : Form 
    {
        // Sets Intagers for the Timers.
        int TimeGone = 0;
        int TimeLeft;
        int sec = 1;
        int Tensec = 10;
        int thirtysec = 30;
        int OneMin = 60;
        int FiveMins = 301;
        int CustomTime = 0;
        public bool Safe = true;

        // "Secert" Location outside statments to allow extern methods.

        // Lock Computer Screen
        [DllImport("user32")]
        public static extern void LockWorkStation();

        // Shutdown Computer
        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

        // Restart Computer
        [DllImport("Powrprof.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);

        public MainForm()
        {
            InitializeComponent();
            txtCustomTime.Enabled = false;
            
        } 
    
        // btnOption = This is where the option (Lock, Sleep, etc.. ) are.
        // Stops the Timer and Stops the Program from Running (Still Runs the Code)

        private void btnOption_Click(object sender, EventArgs e)
        {
            
            OptionTimer.Stop();
            btnStop_Click(sender, e);
            // Checks to see if the Lock Button is True (Checked) then it sees if the Safety Button is ON or OFF
            // Then it tells the computer to lock.
            if (rdobtnLock.Checked == true)
            {
                if (rdobtnSafeOFF.Checked == true)
                {
                    LockWorkStation();
                    //SendMail.SendTestMail();
                    
                }
                else if (rdobtnSafeON.Checked == true)
                {
                    MessageBox.Show("Computer Locked!", this.Text);
                }
            }
            // Checks to see if the Log Off Button is True (Checked) then it sees if the Safety Button is ON or OFF
            // Then it tells the computer to Log Off.
            if (rdobtnLogOff.Checked == true)
            {
                if (rdobtnSafeOFF.Checked == true)
                {                  
                    ExitWindowsEx(0, 0);
                }
                else if (rdobtnSafeON.Checked == true)
                {
                    MessageBox.Show("Computer Logged Off", this.Text);
                }
            }
            // Checks to see if the Switch User Button is True (Checked) then it sees if the Safety Button is ON or OFF
            // Then it tells the computer to Switch User.
            // Computer Sleep
            if (rdobtnSleep.Checked == true)
            {
                if (rdobtnSafeOFF.Checked == true)
                {
                    
                    SetSuspendState(false, true, true);
                }
                else if (rdobtnSafeON.Checked == true)
                {
                    MessageBox.Show("Computer Sleep", this.Text);
                }
            }
            // Computer Hibinate
            if (rdobtnHibinate.Checked == true)
            {
                if (rdobtnSafeOFF.Checked == true)
                {
                   

                    SetSuspendState(true, true, true);
                }
                else if (rdobtnSafeON.Checked == true)
                {
                    MessageBox.Show("Computer Hibinated", this.Text);
                }
            }
            // Computer Shutdown 
            if (rdobtnShutdown.Checked == true)
            {
                if (rdobtnSafeOFF.Checked == true)
                {
                  

                    Process.Start("shutdown", "/s /t 0");
                }
                else if (rdobtnSafeON.Checked == true)
                {
                    MessageBox.Show("Computer Shutdown", this.Text);
                }
            }
            // Computer Restart 
            if (rdobtnStop.Checked == true)
            {
                if (rdobtnSafeOFF.Checked == true)
                {
                   

                    Process.Start("shutdown", "/r /t 0");
                }
                else if (rdobtnSafeON.Checked == true)
                {
                    MessageBox.Show("Computer Restarted", this.Text);
                }
            }
        }
        // Stops the Timer and changes the value of the timer & Progress Bar to 0.
        // It Stops the Timer and RE Enables some items / groups on the form. 
        private void btnStop_Click(object sender, EventArgs e)
        {
            TimeGone = 0;
            tsProgBar.Value = 0;
            tsMessage.Text = "Ready";
            //lblTime.Text = TimeGone + " Seconds";
            OptionTimer.Stop();
            gbTime.Enabled = true;
            gbxSAFE.Enabled = true;
            gpbox.Enabled = true;
            if (rdoCustomTime.Checked == true)
            {
                txtCustomTime.Enabled = true;
            }
            else
            {
                return;
            }
        }
        // Closes the Application
        private void btnCloseApp_Click(object sender, EventArgs e)
        {
           
        }

        private void txtCustomTime_TextChanged(object sender, EventArgs e)
        {
            bool enteredLetter = false;
            Queue<char> text = new Queue<char>();
            foreach (var ch in this.txtCustomTime.Text)
            {
                if (char.IsDigit(ch))
                {
                    text.Enqueue(ch);

                }
                else
                {
                    enteredLetter = true;
                }
            }

            if (enteredLetter)
            {
                StringBuilder sb = new StringBuilder();
                while (text.Count > 0)
                {
                    sb.Append(text.Dequeue());
                }

                this.txtCustomTime.Text = sb.ToString();
                this.txtCustomTime.SelectionStart = this.txtCustomTime.Text.Length;
                lblTimeLbl.Text = txtCustomTime.Text + " Seconds";
            }
        }

        private void lnkWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://loganwalker.co.uk/");
        }

        private void rdobtnSafeON_CheckedChanged(object sender, EventArgs e)
        {
            Safety.Text = "Safe Mode: [ON]";
        }

        private void rdobtnSafeOFF_CheckedChanged(object sender, EventArgs e)
        {
            Safety.Text = "Safe Mode: [OFF]";
        }

        private void txtCustomTime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Enter key is down
                txtCustomTime.Enabled = false;
                btnSetTimer_Click(sender, e);
            }
        }
        private void btnSetTimer_Click(object sender, EventArgs e)
        {       

            if (Safe == true)             
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure that you want to run the program?\nYour selected option is : " + PopUpLable.Text + "\nYour time set is : " + lblTimeLbl.Text + "\nPlease choose Yes (to continue) or no (to change options)!", "Application Fortuantional", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (TimeGone <= 1)
                    {
                        if (rdobtnTestModeNorm.Checked == true)
                        {
                            btnStop_Click(sender, e);
                            OptionTimer.Start();
                            gbTime.Enabled = false;
                            gbxSAFE.Enabled = false;
                            gpbox.Enabled = false;
                            OptionTimer.Interval = 1000;
                        }
                        else if (rdobtnTestModeFast.Checked == true)
                        {
                            OptionTimer.Start();
                            gbTime.Enabled = false;
                            gbxSAFE.Enabled = false;
                            gpbox.Enabled = false;
                            OptionTimer.Interval = 1;
                        }
                    }
                    else
                    {
                        tsMessage.Text = "Can't Procceed!";
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    btnStop_Click(sender, e);
                }
            }
            else if (Safe == false)
            {
                if (TimeGone <= 1)
                {
                    if (rdobtnTestModeNorm.Checked == true)
                    {
                        btnStop_Click(sender, e);
                        OptionTimer.Start();
                        gbTime.Enabled = false;
                        gbxSAFE.Enabled = false;
                        gpbox.Enabled = false;
                        OptionTimer.Interval = 1000;
                    }
                    else if (rdobtnTestModeFast.Checked == true)
                    {
                        OptionTimer.Start();
                        gbTime.Enabled = false;
                        gbxSAFE.Enabled = false;
                        gpbox.Enabled = false;
                        OptionTimer.Interval = 1;
                    }
                }
            }            
        }
        private void Settings(object sender, EventArgs e)
        {

        }
        private void rdoCustomTime_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCustomTime.Checked == true)
            {
                CustomTime = Convert.ToInt32(txtCustomTime.Text);
                CustomTime = int.Parse(txtCustomTime.Text);

                txtCustomTime.Enabled = true;
                lblTimeLbl.Text = CustomTime + " Seconds";
               
            }
            else
            {
                txtCustomTime.Enabled = false;
                lblTimeLbl.Text = txtCustomTime.Text + " Seconds";
            }
        }

        private void rdobtnLock_CheckedChanged(object sender, EventArgs e)
        {
            if (rdobtnLock.Checked == true)
            {
                btnOption.Text = "Instant Lock";
                PopUpLable.Text = "Lock";
            }
        }
        private void rdobtnLogOff_CheckedChanged(object sender, EventArgs e)
        {
            if (rdobtnLogOff.Checked == true)
            {
                btnOption.Text = "Instant Log Off";
                PopUpLable.Text = "Log Off";
            }
        }
        private void rdobtnSleep_CheckedChanged(object sender, EventArgs e)
        {
            if (rdobtnSleep.Checked == true)
            {
                btnOption.Text = "Instant Sleep";
                PopUpLable.Text = "Sleep";
            }
        }
        private void rdobtnHibinate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdobtnHibinate.Checked == true)
            {
                btnOption.Text = "Instant Hibinatation";
                PopUpLable.Text = "Hibinatation";
            }
        }
        private void rdobtnShutdown_CheckedChanged(object sender, EventArgs e)
        {
            if (rdobtnShutdown.Checked == true)
            {
                btnOption.Text = "Instant Shutdown";
                PopUpLable.Text = "Shutdown";
            }
        }
        private void rdobtnStop_CheckedChanged(object sender, EventArgs e)
        {
            if (rdobtnStop.Checked == true)
            {
                btnOption.Text = "Instant Restart";
                PopUpLable.Text = "Restart";
            }
        }

        private void OptionTimer_Tick(object sender, EventArgs e)
        {
            if (rdobtn10Sec.Checked == true)
            {
                if (TimeGone < Tensec)
                {
                    if (rdobtnTestModeNorm.Checked == true)
                    {
                        OptionTimer.Interval = 1000;
                        TimeGone = TimeGone + sec;
                        TimeLeft = Tensec - sec;
                        tsProgBar.Value = 100 * TimeGone / Tensec;
                        tsProgDone.Text = tsProgBar.Value + "%";
                        tsMessage.Text = "Ready";
                        //lblTime.Text = DateTime.Now.ToString("HH:mm:ss") + "("+ TimeLeft +")"+ "Seconds Left";//+ TimeGone + " Seconds";
                    }
                    if (rdobtnTestModeFast.Checked == true)
                    {
                        OptionTimer.Interval = 1;
                        TimeGone = TimeGone + sec;
                        tsProgBar.Value = 100 * TimeGone / Tensec;
                        tsProgDone.Text = tsProgBar.Value+"%";
                        tsMessage.Text = "Ready";
                        lblTime.Text = TimeGone + " Seconds";
                    }
                }
                else
                {
                    OptionTimer.Stop();
                    btnOption_Click(sender, e);
                    tsMessage.Text = "Time's up!";
                    gbTime.Enabled = true;
                    gbxSAFE.Enabled = true;
                    gpbox.Enabled = true;
                    return;
                }
            }
            if (rdobtn30Sec.Checked == true)
            {
                if (TimeGone < thirtysec)
                {
                    if (rdobtnTestModeNorm.Checked == true)
                    {
                        OptionTimer.Interval = 1000;
                        TimeGone = TimeGone + sec;
                        tsProgBar.Value = 100 * TimeGone / thirtysec;
                        tsProgDone.Text = tsProgBar.Value + "%";
                        tsMessage.Text = "Ready";
                        lblTime.Text = TimeGone + " Seconds";
                    }
                    if (rdobtnTestModeFast.Checked == true)
                    {
                        OptionTimer.Interval = 1;
                        TimeGone = TimeGone + sec;
                        tsProgBar.Value = 100 * TimeGone / thirtysec;
                        tsProgDone.Text = tsProgBar.Value + "%";
                        tsMessage.Text = "Ready";
                        lblTime.Text = TimeGone + " Seconds";
                    }
                }
                else
                {
                    OptionTimer.Stop();
                    btnOption_Click(sender, e);
                    tsMessage.Text = "Time's up!";
                    gbTime.Enabled = true;
                    gbxSAFE.Enabled = true;
                    gpbox.Enabled = true;
                    return;
                }
            }
            if (rdobtn1Min.Checked == true)
            {
                if (TimeGone < OneMin)
                {
                    if (rdobtnTestModeNorm.Checked == true)
                    {
                        OptionTimer.Interval = 1000;
                        TimeGone = TimeGone + sec;
                        tsProgBar.Value = 100 * TimeGone / OneMin;
                        tsProgDone.Text = tsProgBar.Value + "%";
                        tsMessage.Text = "Ready";
                        lblTime.Text = TimeGone + " Seconds";
                    }
                    if (rdobtnTestModeFast.Checked == true)
                    {
                        OptionTimer.Interval = 1;
                        TimeGone = TimeGone + sec;
                        tsProgBar.Value = 100 * TimeGone / OneMin;
                        tsProgDone.Text = tsProgBar.Value + "%";
                        tsMessage.Text = "Ready";
                        lblTime.Text = TimeGone + " Seconds";
                    }
                }
                else
                {
                    OptionTimer.Stop();
                    btnOption_Click(sender, e);
                    tsMessage.Text = "Time's up!";
                    gbTime.Enabled = true;
                    gbxSAFE.Enabled = true;
                    gpbox.Enabled = true;
                    return;
                }
            }
            if (rdobtn5Mins.Checked == true)
            {
                int Min = TimeGone / 60;
                int Seconds = TimeGone % 60;

                if (TimeGone < FiveMins)
                {
                    if (rdobtnTestModeNorm.Checked == true)
                    {
                        OptionTimer.Interval = 1000;
                        TimeGone = TimeGone + sec;
                        tsProgBar.Value = 100 * TimeGone / FiveMins;
                        tsProgDone.Text = tsProgBar.Value + "%";
                        tsMessage.Text = "Ready";
                        lblTime.Text = TimeGone + " Seconds";
                    }
                    if (rdobtnTestModeFast.Checked == true)
                    {
                        OptionTimer.Interval = 1;
                        TimeGone = TimeGone + sec;
                        tsProgBar.Value = 100 * TimeGone / FiveMins;
                        tsProgDone.Text = tsProgBar.Value + "%";
                        tsMessage.Text = "Ready";
                        lblTime.Text = TimeGone + " Seconds";
                    }
                    if (TimeGone < 60)
                    {
                        lblTime.Text = Seconds + " Seconds";
                    }
                    else if (TimeGone > 60)
                    {
                        lblTime.Text = Min + " Minute and " + Seconds + " Seconds";
                        if (Min >= 2)
                        {
                            lblTime.Text = Min + " Minutes and " + Seconds + " Seconds";
                        }
                    }
                }
                else
                {
                    OptionTimer.Stop();
                    btnOption_Click(sender, e);
                    tsMessage.Text = "Time's up!";
                    gbTime.Enabled = true;
                    gbxSAFE.Enabled = true;
                    gpbox.Enabled = true;
                    return;
                }
            }
            //Custom Timer 
            if (rdoCustomTime.Checked == true)
            {
                int Min = TimeGone / 60;
                int Seconds = TimeGone % 60;
                int Hour = 0;


                int anInteger;
                if (int.TryParse(txtCustomTime.Text, out anInteger) == false)
                {
                    OptionTimer.Stop();
                    MessageBox.Show("Please enter a valid number between 0 - 999,999,999", this.Text);
                    txtCustomTime.Text = "0";
                    btnStop_Click(sender, e);
                    return;
                }
                else
                {
                    // Converts Text to Int (Int = Number)
                    CustomTime = Convert.ToInt32(txtCustomTime.Text);
                    CustomTime = int.Parse(txtCustomTime.Text);


                    if (CustomTime <= 999999999)
                    {
                        //txtCustomTime.Text = txtCustomTime;
                        if (TimeGone < CustomTime)
                        {
                            if (rdobtnTestModeNorm.Checked == true)
                            {
                                OptionTimer.Interval = 1000;
                                txtCustomTime.Enabled = false;
                                TimeGone = TimeGone + sec;
                                tsProgBar.Value = 100 * TimeGone / CustomTime;
                                tsProgDone.Text = tsProgBar.Value + "%";
                                tsMessage.Text = "Ready";
                                lblTime.Text = TimeGone + " Seconds";
                            }
                            if (rdobtnTestModeFast.Checked == true)
                            {
                                OptionTimer.Interval = 1;
                                txtCustomTime.Enabled = false;
                                TimeGone = TimeGone + sec;
                                tsProgBar.Value = 100 * TimeGone / CustomTime;
                                tsProgDone.Text = tsProgBar.Value + "%";
                                tsMessage.Text = "Ready";
                                lblTime.Text = TimeGone + " Seconds";
                            }

                            //txtCustomTime.Enabled = false;
                            //TimeGone = TimeGone + sec;
                            //tsProgBar.Value = 100 * TimeGone / CustomTime;
                            //tsMessage.Text = "Ready";

                            if (TimeGone <= 1)
                            {
                                lblTime.Text = Seconds + " Second";
                            }
                            if (TimeGone >= 2)
                            {
                                lblTime.Text = Seconds + " Seconds";
                            }
                            if (TimeGone > 60)
                            {
                                lblTime.Text = Min + " Minute and " + Seconds + " Seconds";
                            }
                            if (Min >= 2)
                            {
                                lblTime.Text = Min + " Minutes and " + Seconds + " Seconds";
                            }
                            if (Min >= 60)
                            {
                                Min -= 60;
                                Hour += 1;
                            }
                            if (Hour >= 1 && Min >= 60)
                            {
                                Min -= 60;
                                Hour += 1;
                            }
                            if (Hour == 1)
                            {
                                lblTime.Text = Hour + " Hour, " + Min + " Minute and " + Seconds + " Seconds";
                            }
                            if (Hour >= 1 && Min >= 2)
                            {
                                lblTime.Text = Hour + " Hour, " + Min + " Minutes and " + Seconds + " Seconds";
                            }
                            if (Hour > 1)
                            {
                                lblTime.Text = Hour + " Hours, " + Min + " Minute and " + Seconds + " Seconds";
                            }
                            if (Hour > 1 && Min >= 2)
                            {
                                lblTime.Text = Hour + " Hours, " + Min + " Minutes and " + Seconds + " Seconds";
                            }
                        }


                        else
                        {
                            OptionTimer.Stop();
                            btnOption_Click(sender, e);
                            txtCustomTime.Enabled = true;
                            tsMessage.Text = "Time's up!";
                            gpbox.Enabled = true;
                            gbTime.Enabled = true;
                            gbxSAFE.Enabled = true;
                            return;
                        }
                    }
                }
            }

            else
            {
                // Saftey Net / Catch / Return
                //MessageBox.Show("Too many numbers!", this.Text);
                return;
            }
                }
                       
        private void txtCustomTime_Leave(object sender, EventArgs e)
        {
            if (txtCustomTime.Text.Trim() == "")
            {
                txtCustomTime.Text = "0";
                CustomTime = 0;
            }
            else
            {
                return;
            }
        }

        private void tsAbout_Click(object sender, EventArgs e)
        {
            var AboutForm = new About();
            AboutForm.Show();
        }

        private void tsUserFeedback_Click(object sender, EventArgs e)
        {
            var USFB = new UserFeedback();
            USFB.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void tsOptions_Click(object sender, EventArgs e)
        {
            var Options = new Option(this);
            Options.Show();
        }

        private void rdobtn10Sec_CheckedChanged(object sender, EventArgs e)
        {
            if (rdobtn10Sec.Checked == true)
            {
                lblTimeLbl.Text = "10 Seconds";
            }
        }

        private void rdobtn30Sec_CheckedChanged(object sender, EventArgs e)
        {
            if (rdobtn30Sec.Checked == true)
            {
                lblTimeLbl.Text = "30 Seconds";
            }
        }

        private void rdobtn1Min_CheckedChanged(object sender, EventArgs e)
        {
            if (rdobtn1Min.Checked == true)
            {
                lblTimeLbl.Text = "1 Minute (60 Seconds)";
            }
        }

        private void rdobtn5Mins_CheckedChanged(object sender, EventArgs e)
        {
            if (rdobtn5Mins.Checked == true)
            {
                lblTimeLbl.Text = "5 Minutes (301 Seconds)";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void DateTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");           
        }
            }
        }