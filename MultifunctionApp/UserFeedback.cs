using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace MultifunctionApp
{
    public partial class UserFeedback : Form
    {
        int Age;
        public UserFeedback()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = String.Empty;
            txtLocation.Text = String.Empty;
            chkAgree.Checked = false;
            rdoMale.Checked = true;
            rdoFemale.Checked = false;
            PersonalFeedback.Text = String.Empty;
            txtEmail.Text = String.Empty;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            txtName.Text = txtName.Text.Trim();
            txtLocation.Text = txtLocation.Text.Trim();            
            PersonalFeedback.Text = PersonalFeedback.Text.Trim();
            txtEmail.Text = txtEmail.Text.Trim();

            if (rdoMale.Checked == true)
            {
                lblGender.Text = "Male";
            }
            if (rdoFemale.Checked == true)
            {
                lblGender.Text = "Female";                    
            }
            if (txtName.Text == String.Empty)
            {
                txtName.BackColor = Color.Red;
            }
            if (txtLocation.Text == String.Empty)
            {
                txtLocation.BackColor = Color.Red;
            }
            if (txtEmail.Text == String.Empty)
            {
                txtEmail.BackColor = Color.Red;
            }
            if (PersonalFeedback.Text == String.Empty)
            {
                PersonalFeedback.BackColor = Color.Red;
            }
            if (Age >= 100)
            {
                MessageBox.Show("I doubt that you are this old...");
                txtAgeBox.BackColor = Color.Red;
            }
            if (chkAgree.Checked == false)
            {
                lblActivity.Text = "No";
            }
            else if (chkAgree.Checked == true)
            {
                lblActivity.Text = "Yes";
            }
            if (lblActivity.Text == "No")
            {

                Age = Convert.ToInt32(txtAgeBox.Text);
                Age = int.Parse(txtAgeBox.Text);

                MessageBox.Show("Message Sent!", this.Name);
            }
            if (lblActivity.Text == "Yes")
            {

                Age = Convert.ToInt32(txtAgeBox.Text);
                Age = int.Parse(txtAgeBox.Text);

                MailMessage mail = new MailMessage();
                SmtpClient FeedbackClient = new SmtpClient("//smtphost");

                mail.From = new MailAddress("emailfrom");
                mail.To.Add("toaddress");
                mail.Subject = "User Feedback - Multifunctional Tool! (STATS)";
                mail.Body = 
                    "Name: " + txtName.Text + "\n" + 
                    "Age: " + Age + "\n" + 
                    "Gender: " + lblGender.Text + "\n" + 
                    "Location: " + txtLocation.Text + "\n" + 
                    "Email: " + txtEmail.Text + "\n" + 
                    "Feedback: " + PersonalFeedback.Text + "\n" +                   
                    "User Activity Consent: " + lblActivity.Text + "\n" +
                    "\n" + "\n" +
                    "User Name: " + System.Environment.UserName + "\n" +
                    "Computer Name: " + System.Environment.MachineName + "\n" +
                    "Computer Domain Name: " + System.Environment.UserDomainName + "\n"+ 
                    "Operating System Version: " + System.Environment.OSVersion + "\n";

                FeedbackClient.Port = 25;
                FeedbackClient.Credentials = new System.Net.NetworkCredential("loginemail", "//");
                FeedbackClient.EnableSsl = true;


                FeedbackClient.Send(mail);
                MessageBox.Show("Message Sent!", this.Name);
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == String.Empty)
            {
                txtName.Text = txtName.Text.Trim();
                txtName.BackColor = Color.Red;
            }
            else
            {
                txtName.Text = txtName.Text.Trim();
                txtName.BackColor = Color.White;
            }
        }

        private void txtLocation_Leave(object sender, EventArgs e)
        {
            if (txtLocation.Text.Trim() == String.Empty)
            {
                txtLocation.Text = txtLocation.Text.Trim();
                txtLocation.BackColor = Color.Red;
            }
            else
            {
                txtLocation.Text = txtLocation.Text.Trim();
                txtLocation.BackColor = Color.White;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() == String.Empty)
            {
                txtEmail.Text = txtEmail.Text.Trim();
                txtEmail.BackColor = Color.Red;
            }
            else
            {
                txtEmail.Text = txtEmail.Text.Trim();
                txtEmail.BackColor = Color.White;
            }
        }

        private void PersonalFeedback_Leave(object sender, EventArgs e)
        {
            if (PersonalFeedback.Text.Trim() == String.Empty)
            {
                PersonalFeedback.Text = PersonalFeedback.Text.Trim();
                PersonalFeedback.BackColor = Color.Red;
            }
            else
            {
                PersonalFeedback.Text = PersonalFeedback.Text.Trim();
                PersonalFeedback.BackColor = Color.White;
            }
        }
        private void txtAgeBox_TextChanged(object sender, EventArgs e)
        {
            
            bool enteredLetter = false;
            Queue<char> text = new Queue<char>();
            foreach (var ch in this.txtAgeBox.Text)
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

                this.txtAgeBox.Text = sb.ToString();
                this.txtAgeBox.SelectionStart = this.txtAgeBox.Text.Length;
            }
            if (Age >= 100)
            {
                MessageBox.Show("I doubt that you are this old....");
                txtAgeBox.BackColor = Color.Red;
            }
        }

        private void txtAgeBox_Leave(object sender, EventArgs e)
        {
            if (txtAgeBox.Text.Trim() == "")
            {
                txtAgeBox.Text = "17";
                
            }
            else if (Age >= 100)
            {
                MessageBox.Show("I doubt that you are this old....");
                txtAgeBox.BackColor = Color.Red;
            }
        }
    }
}
