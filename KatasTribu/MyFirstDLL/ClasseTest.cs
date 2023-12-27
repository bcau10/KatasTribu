using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyFirstDLL
{
    public class ClasseTest
    {
        public static string GetFileName2(string dir)
        {
            if (File.Exists(dir))
            {
                return (Path.GetFileName(dir));
            }
            else
            {
                return ("File not found");
            }
        }
    }
}
