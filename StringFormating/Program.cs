using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string speech = "He said, \"Hello, World!\"";
            Console.WriteLine(speech);
             string path = @"C:\Program Files\\MyApp\app.exe"+ "\nNew line here ";
            Console.WriteLine(path);
        }
    }
}
