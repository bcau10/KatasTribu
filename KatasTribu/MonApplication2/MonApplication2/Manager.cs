using System;
using System.Collections.Generic;
using System.Text;

namespace MonApplication2
{
    class Manager: Employee
    {
        public sealed override void Work()
        {
            Console.WriteLine("It manages a team...");
        }
    }
}
