using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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

            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            //String Format method
            Console.WriteLine("Your Name is : " + name + "\nYour Age is : " + age);
            Console.WriteLine("Your Name is : {0}\nYour Age is : {1}", name, age);

            //String Interpolation
            Console.WriteLine($"Your Name is : {name}\nYour Age is : {age}");

            //String concatenation
            string test=string.Concat("Your Name is : ", name, "\nYour Age is : ", age);
            Console.WriteLine(test);

            string[] names= { "Alice", "Bob", "Charlie" };
            Console.WriteLine(string.Concat(names));

            //Empty string check
            Console.WriteLine("Enter your name :   ");
            string emp = Console.ReadLine();

            if (emp == string.Empty)
            {
                Console.WriteLine("You did not enter your name.");
            }
            else
            {
                Console.WriteLine("Hello, " + emp);
            }

            //string equal function
            string message = "Hello";
            string message2 = "Hello";

            if (message.Equals(message2))
            {//!message.Equals("") for empty check of the string
                Console.WriteLine("Strings are equal.");
            }
            else
            {
                Console.WriteLine("Strings are not equal.");
            }

            //string looping
            string loopString = "Hello, This is the world of inovation";
            for(int i = 0; i < loopString.Length; i++) {
                Console.Write(loopString[i]);
                Thread.Sleep(250);//1000ms=1sec
            }   
            Console.WriteLine("\n"+loopString.Contains("Hello"));//true
            bool contain=false;
            for (int i = 0; i < loopString.Length; i++)
            {
                if (loopString[i].Equals('i'))
                {
                    Console.WriteLine(loopString[i]);
                    contain = true;
                }
            }
            Console.WriteLine(contain);

            //Empty string check
            Console.WriteLine("Enter your name : ");
            string emp2 = Console.ReadLine();
            if (emp2 == string.Empty) {
                Console.WriteLine("You did not enter your name.");
            }

            if (emp2 == "")
            {
                Console.WriteLine("You did not enter your name.");
            }

            if(emp2.Equals(""))
            {
                Console.WriteLine("You did not enter your name.");
            }

            if(string.IsNullOrEmpty(emp2))
            {
                Console.WriteLine("You did not enter your name.");
            }
            Console.ReadLine();
        }
    }
}
