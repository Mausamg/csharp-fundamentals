using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Numeric Data Types
            int age =21;
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            long bigNumber = 12345678901234;
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            double negative= -3.14;
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            float pi=3.14f;
            Console.WriteLine(pi);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            decimal money= 19.99m;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);


            //Text Based Data Types
            string name = "MausamG";
            char grade = 'A';
            Console.Write("Name: " + name + ", Grade: " + grade);


            Console.ReadLine();
        }
    }
}
