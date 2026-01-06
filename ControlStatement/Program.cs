using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 0)
            {
                Console.WriteLine("Invalid input.");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }

            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            int anotherNumber = Convert.ToInt32(Console.ReadLine());
            int multiplication = number * anotherNumber;
            Console.WriteLine("What is the multiplication of {0} and {1} ? ", number, anotherNumber);
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == multiplication)
            {
                Console.WriteLine("Correct answer!");
            }
            else
            {
                Console.WriteLine("Wrong answer. The correct answer is " + multiplication);
            }
            Console.ReadLine();
        }
    }
}
