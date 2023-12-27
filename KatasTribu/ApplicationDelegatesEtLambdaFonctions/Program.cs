using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstDLL;
namespace ApplicationDelegatesEtLambdaFonctions
{
    class Program
    {
        private delegate int Calcul(int a, int b);
        private static Calcul method;
        static void Main(string[] args)
        {
            method = (a, b) =>  //c'est une expression lambda
            {
                return (a + b);
            };
            int result = method(2, 5);
            Console.WriteLine(result);

            result = method(10, 20);
            Console.WriteLine(result);

            Console.WriteLine("---------------------");

            int c = 3;
            method = (a, b) =>  //c'est une expression lambda
            {
                c = 8;
                return (a * b + c);
            };
            result = method(2, 5);
            Console.WriteLine(result);

            Console.ReadLine();

            //MaClasse.GetFileName(""); Appel référence MyFirstDll
        }
    }
}
