using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                long monEntierAConvertirEnChiffresRomains = (long)Convert.ToDouble(args[0]);
                string LogFilePath = string.Format(ConfigurationManager.AppSettings["LogFilePath"], DateTime.Now.ToString("yyyyMMdd_hhmmss") + "_" + "Nombre Souhaite :" + monEntierAConvertirEnChiffresRomains);

                LogWriter.logFilePath = LogFilePath;
                LogWriter.TraceInfo("Version : "+Application.ProductVersion + " - " + Application.ExecutablePath + " - Serveur : " + Environment.MachineName);
                LogWriter.TraceInfo("Nombre à convertir : " + monEntierAConvertirEnChiffresRomains);

                Console.WriteLine("Vous souhaitez convertir  le chiffre suivant : " + monEntierAConvertirEnChiffresRomains);
                //Console.WriteLine("resultat : " + RomanNumeralsImpl.EnChiffreRomain(768));
                Console.WriteLine("Resultat : " + RomanNumeralsImpl.EnChiffresRomains(monEntierAConvertirEnChiffresRomains));
                LogWriter.TraceInfo("Resultat : " + RomanNumeralsImpl.EnChiffresRomains(monEntierAConvertirEnChiffresRomains));
                LogWriter.TraceInfo("Tâche finie");
                //ajout en plus pour feature branche maBrancheTest

            }  
            catch (Exception e)
            {
                Console.WriteLine("Exception : " + e);
            }
        }
    }
}
