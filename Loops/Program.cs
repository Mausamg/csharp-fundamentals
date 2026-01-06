using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((i + 1) + " Hello world");
            }

            for (int i = 0; i < 10; i += 2)
            {
                Console.WriteLine((i + 1) + " Hello world");
            }

            Console.WriteLine("How many time do you want to print hi? ");
            int times = Convert.ToInt32(Console.ReadLine());

            if (times == 0)
            {
                Console.WriteLine("You chose 0, so nothing to print.");
                return;
            }
            else if (times < 0)
            {
                Console.WriteLine("Negative number entered, please enter a positive number next time.");
                return;
            }
            else { 
                for (int i = 0; i < times; i++)
                {
                    Console.WriteLine((i + 1) + " Hi");
                }
        }
        }
    }
}