using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void applicationFizzBuzz()
        {
            int c = 1;
            FizzBuzz.Process(c);
        }
        static void Main(string[] args)
        {
            applicationFizzBuzz();
            string maChaine = "hello";
            string maChaine2 = "bonjour";
            Console.WriteLine($"{maChaine}");
            Console.WriteLine($"{maChaine2}");
            Console.WriteLine(String.Format("c est ma chaine : ", maChaine));
        }
    }
}
