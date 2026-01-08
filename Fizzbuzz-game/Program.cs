using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the FizzBuzz game! ");
            Console.WriteLine("Enter a game number:");
            int gameNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= gameNumber; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadLine();
        }
    }
}
