using System;
using System.Collections.Generic;

namespace PrimeFactors
{
    //https://www.infinimath.com/espaceeducation/tangenteeducation/articles/TE15/FacteursPremiers.pdf
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1000;
            //List<int> resultat = new List<int>();
            //resultat=PrimeFactors.Decomposition(number);
            Console.WriteLine("resultat : "+PrimeFactorsImpl.Generate(number)) ;
            Console.WriteLine("resultat : " + PrimeFactorsImpl.Decomposition(number));
        }
    }
}
