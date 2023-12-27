using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstDLL;
using System.IO;

namespace ApplicationAttributesInDotNetCSharp
{
    class Program
    {
        //Test Utilisation System.Collections.Generic pour Implementer IEnumerable<T>
        public static void TestImplementationIEnumerableT()
        {
            TestStreamReaderEnumerable();
            Console.WriteLine("---");
            TestReadingFile();
        }
        public static void TestStreamReaderEnumerable()
        {
            //on vérifie la mémoire avant que l'iterator soit utilisé
            long memoryBefore = GC.GetTotalMemory(true);
            IEnumerable<String> stringsFound;
            //try
            //{
            //    stringsFound =
            //        from line in new StreamReaderEnumerable("C:/Users/basti/Documents/Bastien/ESILV/Capfi/Groupama AM/Readme-TestCollectionssGeneric.txt")
            //        where line.Contains("5. Contact")
            //        select line;
            //    Console.WriteLine("Found: " + stringsFound.Count());
            //}
            //catch (FileNotFoundException)
            //{
            //    Console.WriteLine(@"This example requires a file named C:/temp/tempFile.txt");
            //}
            ////Check the memory after the iterator and output it to the console
            //long memoryAfter = GC.GetTotalMemory(false);
            //Console.WriteLine("Memory used with Iterator = \t") + string.Format((memoryAfter - memoryBefore) / 1000).ToString(),"n")+"kb");
        }
        public static void TestReadingFile()
        {

            //on vérifie la mémoire avant que l'iterator soit utilisé
            long memoryBefore = GC.GetTotalMemory(true);
            //StreamReader sr;
            //try
            //{
            //    sr = File.OpenText("Readme-TestCollectionssGeneric.txt");
            //}
            //catch (FileNotFoundException)
            //{
            //    Console.WriteLine(@"This example requires a file named C:\Users\basti\Documents\Bastien\ESILV\Capfi\Groupama AM\Readme-TestCollectionssGeneric.txt");
            //    return;
            //}
            //add the file contents to a generic list of strings
            //List<string> fileContents = new List<string>();
            //while (!sr.EndOfStream)
            //{
            //    fileContents.Add(sr.ReadLine());
            //}
            //Check for the string
            //var stringsFound =
            //    from line in fileContents
            //    where line.Contains("string to search for")
            //    select line;

            //sr.Close();
            //Console.WriteLine("Found: " + stringsFound.Count());

            //Check the memory after when the iterator is not used, and output it to the console
            long memoryAfter = GC.GetTotalMemory(false);
            //Console.WriteLine("Memory used with Iterator = \t" +
            //    string.Format((memoryAfter - memoryBefore) / 1000).ToString(), "n") + "kb");

        }

        static void Main(string[] args)
        {
            TestImplementationIEnumerableT();
            MaClasse.GetFileName("qvsgb");
            
        }
    }
}
