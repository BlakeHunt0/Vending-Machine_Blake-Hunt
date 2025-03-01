using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Vending_Machine_Blake_Hunt
{
    internal class Logger
    {
        public static void logToText(string s)
        {
            //MUST MAKE RELATIVE PATH
            //
            //txt location
            string logTxt = @"C:\Users\Brine\source\repos\Vending-Machine_Blake-Hunt-master\Vending-Machine_Blake-Hunt-master\VendLog.txt";

            //add text to the txt append style
            StreamWriter log = File.AppendText(logTxt);

            string logAppend = s;

            log.WriteLine(logAppend);
            log.Close();
        }
    }
}
