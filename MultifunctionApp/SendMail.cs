using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace MultifunctionApp
{
    public static class SendMail
    {
        public static void SendTestMail()
        {
                    MailMessage mail = new MailMessage();
                    SmtpClient client = new SmtpClient("//SMTPHOSTNAME");

                    mail.From = new MailAddress("//FROMMAILADDRESS");
                    mail.To.Add("//ToAddress");
                    mail.Subject = "//Subject";
                    mail.Body =
                        "Option Chosen: " + "Lock " + "\n"+  
                        "User Name: " + System.Environment.UserName + "\n" +
                        "Computer Name: " + System.Environment.MachineName + "\n" +
                        "Computer Domain Name: " + System.Environment.UserDomainName + "\n" +
                        "Operating System Version: " + System.Environment.OSVersion + "\n";

                    client.Port = 25;
                    client.Credentials = new System.Net.NetworkCredential("//loginname", "//password");
                    client.EnableSsl = true;


                    client.Send(mail);
         }
    }
}
