using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleReadlineApplication
{
    public class Program
    {
        public static void Exo1()
        {
            int c = Console.Read(); //la méthode retourne un int si on fait char= on va avoir des pb à la compilation
            Console.WriteLine(c);
        }
        public static void Exo2()
        {
            Console.WriteLine("Comment allez-vous?");
            string c = Console.ReadLine();
            Console.WriteLine(c);
        }
        //public static void Exo3()
        //{//pour écupérer le retour de la méthode suivante
        //    ConsoleKeyInfo cki = Console.ReadKey();
        //    Console.WriteLine(cki);
        //}
        static void Main(string[] args)
        {
            //Exo1();
            Exo2();
            //Exo3();
        }
    }
}
