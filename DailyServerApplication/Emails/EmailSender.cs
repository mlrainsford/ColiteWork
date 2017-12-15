/* Colite International
 * Author: Mitchell Rainsford
 * Created: 12/15/2017
 * Updated: 
 */

using System;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace DailyServerApplication.Emails
{
    /// <summary>
    /// Simple class used to send emails
    /// </summary>
    public class EmailSender
    {

        string MailSmtpHost;
        int MailSmtpPort;


        /// <summary>
        /// General constructor that sets host and port of the emailer
        /// </summary>
        public EmailSender()
        {
            MailSmtpHost = "smtp-mail.outlook.com";
            MailSmtpPort = 587;
        }


        /// <summary>
        /// Used to send an email with all the details passed through parameter
        /// </summary>
        public bool SendEmail(EmailStructure details)
        {
            string recips = String.Join(",", details.Recipients);

            MailMessage mail = new MailMessage(details.SendingEmail, recips, details.Subject, details.Body);

            // Following allows for HTML emails
            var alternameView = AlternateView.CreateAlternateViewFromString(details.Body, new ContentType("text/html"));
            mail.AlternateViews.Add(alternameView);

            var smtpClient = new SmtpClient(MailSmtpHost, MailSmtpPort);
            smtpClient.Credentials = new NetworkCredential(details.SendingEmail, details.SendingEmailPassword);
            smtpClient.EnableSsl = true;

            // Catches any exceptions thrown while trying to actually send email
            try
            {
                smtpClient.Send(mail);
            }
            catch (Exception exc)
            {
                Console.WriteLine("ERR: " + exc);
                return false;
            }

            return true;
        }


    }
}
