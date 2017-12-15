/* Colite International
 * Author: Mitchell Rainsford
 * Created: 12/15/2017
 * Updated: 
 */

using DailyServerApplication.ProgramManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyServerApplication
{
    /// <summary>
    /// Main class used to start the application
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            ServerManager.GetInstance().StartServer();

        }
    }
}
