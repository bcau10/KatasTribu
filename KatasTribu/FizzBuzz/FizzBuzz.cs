using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static int Process(int input)
        {
            return (input);
        }
        public static string Process2(string input)
        {
            string result = "";
            if (Convert.ToInt32(input) % 3 == 0)
            {
                result = "Fizz";
            }
            else
            {
                result = input;
            }
            return (result);
        }
        public static string Process3(string input)
        {
            string result = "";
            if (Convert.ToInt32(input) % 5 == 0)
            {
                result = "Buzz";
            }
            else
            {
                result = input;
            }
            return (result);
        }

    }
}
