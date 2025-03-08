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
            //txt location
            //current directory must be reversed because it leads to the bin/data folder
            string txtPath = System.IO.Path.Combine(Environment.CurrentDirectory, @"..\..\..\Data\VendLog.txt");
            string txtTruePath = Path.GetFullPath(txtPath);


            //add text to the txt append style
            StreamWriter log = File.AppendText(txtTruePath);

            //get inserted line
            string logAppend = s;

            //write line to txt
            log.WriteLine(logAppend);
            log.Close();
        }
    }
}
