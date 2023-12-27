using System;
using System.Collections.Generic;
using System.Text;

namespace MonApplication2
{
    abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public abstract void Work();
    }
}
