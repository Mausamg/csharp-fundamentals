using System;
using System.Collections.Generic;
using System.Globalization;
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
            else
            {
                for (int i = 0; i < times; i++)
                {
                    Console.WriteLine((i + 1) + " for loop");
                }
            }

            Console.WriteLine("Enter first numsber :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int multiplication = num1 * num2;
            //implementation of for loop 
            Console.WriteLine("What is the multiplication of {0}*{1}:", num1, num2);
            int attempt = 1, maxAttempts = 5;

            while (attempt <= maxAttempts)
            {
                int userAnswer = Convert.ToInt32(Console.ReadLine());

                if (userAnswer == multiplication)
                {
                    Console.WriteLine("Wow, Correct Answer!");
                    break;
                }
                else if (attempt == maxAttempts)
                {
                    Console.WriteLine(
                        "Sorry, you have used all your attempts. The correct answer is {0}",
                        multiplication
                    );
                }
                else
                {
                    Console.WriteLine(
                        "Incorrect Answer. You have {0} attempts left. Try again.",
                        maxAttempts - attempt
                    );
                }

                attempt++;
            }

            Console.WriteLine("Enter your age :");
            int age = Convert.ToInt32(Console.ReadLine());
            string result = age >= 18 ? " You are eligible to vote" : " You are not eligible to vote";
            Console.WriteLine(result);

            double num = 100D / 23;
            Console.WriteLine(num);
            Console.WriteLine(String.Format("The value of num is: {0:F4}", num));


            double money = 10D / 3D;
            Console.WriteLine(money);
            Console.WriteLine(String.Format("The value of money is: {0:F2}", money));
            Console.WriteLine(money.ToString("C"));
            Console.WriteLine(money.ToString("C0"));
            Console.WriteLine(money.ToString("N3"));
            Console.WriteLine(money.ToString("P1"));
            Console.WriteLine(money.ToString("C2"));
            Console.WriteLine(money.ToString("C",CultureInfo.CreateSpecificCulture("en-US")));

            bool success = true;

            while (success)
            {
                Console.Write("Enter a number: ");
                String input = Console.ReadLine();

                if(int.TryParse(input, out int number))
                {
                    Console.WriteLine("You entered the number: " + number);
                    success = false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }

            }

            Console.WriteLine("Enter a number for table multiplication:");
            int tableNum = Convert.ToInt32(Console.ReadLine());
            for (int i=1; i <= 10; i++)
            {
                int num = tableNum * i;
                Console.WriteLine("{0} x {1} = {2}", tableNum, i, num);
            }
            Console.ReadLine();
        }
    }
}