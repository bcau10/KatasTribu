using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Collections;

namespace RomanNumerals
{
    class Program
    {
        public class Person
        {
            public int Id;
        }
        public static void testQuiz()
        {
            ArrayList arr = new ArrayList();
            string str1 = "C#";
            string str2 = "C#";
            string str3;
            string str4;
            str3 = "C#";
            str4 = "C#";
            //Console.Write(Object.ReferenceEquals(str3, str4));
            int i = 0;
            for (; ; )
            {
                if (i < 5)
                {
                    Console.Write(i);
                }
                else
                {
                    break;
                }
                i++;

                int[] tab = new int[5];
                int[] tab2 = new int[] { 1, 2 , 3, 4, 5 };
                var tab3 = new int[5] { 1, 2, 3, 4, 5 };
                tab.Append(1);
            }
            SortedList sortedList = new SortedList()
            {
                {2,true },
                {1,"one" }
            };
            foreach (DictionaryEntry kvp in sortedList)
            {
                Console.Write(kvp.Value);
            }
            int[] arrayTest = { 1, 2, 3 };
            Console.WriteLine(arrayTest[10]);
        }

        public static void display(int val=0)
        {
            Console.WriteLine(val);
        }
        static void Main(string[] args)
        {
            testQuiz();
        //    try
        //    {
        //        long monEntierAConvertirEnChiffresRomains = (long)Convert.ToDouble(args[0]);
        //        //on lève une exception si le nb rentré en paramètre est négatif
        //        if (monEntierAConvertirEnChiffresRomains<0)
        //        {
        //            throw new ArgumentException($"{monEntierAConvertirEnChiffresRomains} must be positive");
        //        }
        //        string LogFilePath = string.Format(ConfigurationManager.AppSettings["LogFilePath"], DateTime.Now.ToString("yyyyMMdd_hhmmss") + "_" + "Nombre Souhaite :" + monEntierAConvertirEnChiffresRomains);

        //        LogWriter.logFilePath = LogFilePath;
        //        LogWriter.TraceInfo("Version : " + Application.ProductVersion + " - " + Application.ExecutablePath + " - Serveur : " + Environment.MachineName);
        //        LogWriter.TraceInfo("Nombre à convertir : " + monEntierAConvertirEnChiffresRomains);

        //        Console.WriteLine("Vous souhaitez convertir  le chiffre suivant : " + monEntierAConvertirEnChiffresRomains);
        //        //Console.WriteLine("resultat : " + RomanNumeralsImpl.EnChiffreRomain(768));
        //        Console.WriteLine("Resultat : " + RomanNumeralsImpl.EnChiffresRomains(monEntierAConvertirEnChiffresRomains));
        //        LogWriter.TraceInfo("Resultat : " + RomanNumeralsImpl.EnChiffresRomains(monEntierAConvertirEnChiffresRomains));
        //        LogWriter.TraceInfo("Tâche finie");
        //        //ajout en plus pour feature branche maBrancheTest

        //    }
        //    catch (ArgumentException e)
        //    {
        //        Console.WriteLine("Exception : " + e);
        //    }
        //    finally
        //    {
        //        Console.WriteLine("hello");
        //    }
        }
    }
}
