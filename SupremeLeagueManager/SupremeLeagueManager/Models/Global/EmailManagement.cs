using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Diagnostics;

using System.Net;
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
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com.");

                mail.From = new MailAddress("pawelkarasinski1981@gmail.com");

                mail.To.Add(recipient);
                mail.Subject = subject;

                mail.IsBodyHtml = true;
                mail.Body = mailBody;

                SmtpServer.Port = 587;

                SmtpServer.UseDefaultCredentials = false;

                SmtpServer.Credentials = new System.Net.NetworkCredential("pawelkarasinski1981@gmail.com", "Margo01VI1982@");
                SmtpServer.EnableSsl = true;

                //SmtpServer.Timeout = 0;
                SmtpServer.Send(mail);

                correct = 1;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            return correct;
        }

        public static int SendViaGmail(string recipient, string subject, string mailBody)
        {
            string password = "Margo01VI1982@";
            string body = mailBody;

            MailAddress senderEmail = new MailAddress("pawelkarasinski1981@gmail.com", "Registration");
            MailAddress receiverEmail = new MailAddress(recipient.ToString(), "Receiver");

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(senderEmail.Address, password);

            MailMessage mailMessage = new MailMessage(senderEmail, receiverEmail);
            mailMessage.Subject = subject;
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = body;

            smtpClient.Send(mailMessage);

            return 1;
        }

        public static int SendViaKomfort(string recipient, string subject, string mailBody)
        {
            int correct = 0;

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("mail.markety.komfort.pl");

                mail.From = new MailAddress("notyfikacja_noweosoby@markety.komfort.pl");

                mail.To.Add(recipient);
                mail.Subject = subject;

                mail.IsBodyHtml = true;
                mail.Body = mailBody;

                SmtpServer.Port = 25;
                SmtpServer.Credentials = new System.Net.NetworkCredential("notyfikacja_noweosoby@markety.komfort.pl", "K0mf0rt123");
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

        public static int SendViwOutlook(string recipient, string subject, string mailBody)
        {
            int correct = 0;

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp-mail.outlook.com");

                mail.From = new MailAddress("pawel.karasinski@komfort.pl");

                mail.To.Add(recipient);
                mail.Subject = subject;

                mail.IsBodyHtml = true;
                mail.Body = mailBody;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("pawel.karasinski@komfort.pl", "Margo01VI1982@");
                SmtpServer.EnableSsl = true;

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