using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Diagnostics;
using System.Net.Mail;

namespace SupremeLeagueManager.Models.Global
{
    public static class EmailManagement
    {
        public static int SendViaO2(string recipient, string subject, string mailBody)
        {
            int correct = 0;

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("poczta.o2.pl");

                mail.From = new MailAddress("pawelkarasinski1981@o2.pl");

                mail.To.Add(recipient);
                mail.Subject = subject;

                mail.IsBodyHtml = true;
                mail.Body = mailBody;

                SmtpServer.Port = 465;
                SmtpServer.Credentials = new System.Net.NetworkCredential("pawelkarasinski1981@o2.pl", "Margo01VI1982@");
                SmtpServer.EnableSsl = true;

                SmtpServer.Timeout = 0;
                SmtpServer.Send(mail);

                correct = 1;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            return correct;
        }
    }
}