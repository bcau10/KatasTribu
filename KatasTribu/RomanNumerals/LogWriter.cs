using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace RomanNumerals
{
    class LogWriter
    {
        readonly static string _logFileFullPath = String.Format(ConfigurationManager.AppSettings["LogFilePath"], DateTime.Now.ToString("yyyyMMdd_hhmmss"));
        public static string logFilePath;

        private static object locker = new Object();
        public static void WriteToLog(string message)
        {
            using (var writer = new StreamWriter(_logFileFullPath, true))
            {
                writer.WriteLine(message);
            }
        }
        public static void TraceInfo(string message)
        {
            Console.WriteLine(string.Format("{0} - {1} : {2}", DateTime.Now.ToString(), "INFO", message));
            try
            {
                WriteToLog(string.Format("{0} - {1} : {2}", DateTime.Now.ToString(), "INFO", message));
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to log " + e.Message);
            }
        }
    }
}

