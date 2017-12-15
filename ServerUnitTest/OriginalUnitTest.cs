/* Colite International
 * Author: Mitchell Rainsford
 * Created: 12/15/2017
 * Updated: 
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using DailyServerApplication.Emails;
using System.Collections.Generic;

namespace ServerUnitTest
{
    /// <summary>
    /// Class used for all the initial unit tests
    /// </summary>
    [TestClass]
    public class OriginalUnitTests
    {
        [TestMethod]
        public void TestEmailSending()
        {
            EmailStructure email = new EmailStructure(new List<string> { "mlrainsford@gmail.com" }, "mrainsford@colite.com", "Colite1992", "TEST", "TESTING 123");
            EmailSender sender = new EmailSender();
            Assert.AreEqual(true, sender.SendEmail(email));
        }
    }
}
