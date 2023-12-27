using System;
using System.Collections.Generic;
using System.Text;

namespace MonApplication2
{
    class Employee:Person
    {
        public double Salary { get; set; }
        public string Designation { get; set; }
        public override void Work()
        {
            Console.WriteLine("It earns...");
        }
        //
    }
}
