/* Colite International
 * Author: Mitchell Rainsford
 * Created: 12/15/2017
 * Updated: 
 */

using DailyServerApplication.Emails;
using System;
using System.Collections.Generic;
using System.Threading;

namespace DailyServerApplication.ProgramManagement
{
    /// <summary>
    /// Main class of the server used to manage all sub-classes and threads
    /// </summary>
    class ServerManager
    {


        private static ServerManager serverMan;


        /// <summary>
        /// Currently a singleton used to return the main class, probably will not take this approach
        /// </summary>
        /// <returns></returns>
        public static ServerManager GetInstance()
        {
            if (serverMan == null)
                serverMan = new ServerManager();
            return serverMan;
        }


        /// <summary>
        /// Starts the server
        /// </summary>
        public void StartServer()
        {
            Console.WriteLine("Sending email...");
            EmailSender emailer = new EmailSender();
            EmailStructure email = new EmailStructure(new List<string> { "mlrainsford@gmail.com" }, "mrainsford@colite.com", "Colite1992", "TEST", "TESTING 123");

            emailer.SendEmail(email);
            Thread.Sleep(1000000000);
        }

    }
}
