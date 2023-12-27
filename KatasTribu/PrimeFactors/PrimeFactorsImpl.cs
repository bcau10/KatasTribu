using System;
using System.Collections.Generic;
using System.Text;

//https://www.youtube.com/watch?v=luvxkidFvjc
namespace PrimeFactors
{
    public class PrimeFactorsImpl
    {
        public static IList<int?> Generate(int number)
        {
            IList<int?> primes = new List<int?>();
            //List, class which implements IList interface
            //IList is a interface and doesn't have any implementation, so the performance of IList depending the class it implements
            for (var candidate = 2; number > 1; candidate++)
            {
                for (; number % candidate == 0; number /= candidate)
                {
                    primes.Add(candidate);
                }
            }
            return (primes);

        }
        public static IList<int> Decomposition(int number)
        {
            IList<int> resultat = new List<int>();
            int d = 2;
            int q;
            while (number%2==0)
            {
                resultat.Add(d);
                q = (number/d);
                number = q;
            }
            d = 3;
            while (d<=number)
            {
                while (number%d==0)
                {
                    resultat.Add(d);
                    q = (number / d);
                    number =q;
                }
                d = d + 2;
            }
            return (resultat);
        }
    }
}
