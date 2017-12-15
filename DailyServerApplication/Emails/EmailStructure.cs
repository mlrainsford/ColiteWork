/* Colite International
 * Author: Mitchell Rainsford
 * Created: 12/15/2017
 * Updated: 
 */

using System.Collections.Generic;

namespace DailyServerApplication.Emails
{
    /// <summary>
    /// Used to define all things needed in the email
    /// </summary>
    public class EmailStructure
    {

        public List<string> Recipients;

        public string SendingEmail;

        public string SendingEmailPassword;

        public string Subject;

        public string Body;

        public List<string> Attachments;


        /// <summary>
        /// General constructor used to take in all the email parameters
        /// </summary>
        public EmailStructure(List<string> Recipients, string email, string pass, string sub, string body, List<string> attach = null)
        {
            this.Recipients = Recipients;
            SendingEmail = email;
            SendingEmailPassword = pass;
            Subject = sub;
            Body = body;
            Attachments = attach;
        }


    }
}
