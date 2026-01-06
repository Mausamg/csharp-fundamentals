using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesandOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 21;
            age++;
            Console.WriteLine("Your age is: " + age);
            age--;
            Console.WriteLine("Your age is: " + age);

            age/=2;
            Console.WriteLine(age);

            string name = "Mausam";
            name += " Shrestha";
            Console.WriteLine(name);

            char ch='a';
            ch++;
            Console.WriteLine(ch);
            ch+= 'b';
            ch++;
            Console.WriteLine(ch);

            int i = 0;
            ++i;
            Console.WriteLine(i);
            i++;
            Console.WriteLine(i);
            Console.WriteLine(i++);
            Console.WriteLine(++i);

            int FirstNumber = 10;
            int SecondNumber = 5;

            Console.WriteLine(FirstNumber / SecondNumber);
            Console.WriteLine(FirstNumber % SecondNumber);

            var newAge = 25;
            Console.WriteLine(newAge);

            var bigNumber = 1234567890123456789L;
            Console.WriteLine(bigNumber);

            var smallDecimal = 12.34F;
            Console.WriteLine(smallDecimal);

            var nameOfPerson = "John Doe";
            Console.WriteLine(nameOfPerson);

            var letter = 'A';
            Console.WriteLine(letter);

            const double Pi = 3.14159;
            Console.WriteLine(Pi);

            const int vat = 20;
            const double percentVAT = vat / 100D;
            int balance = 500;
            Console.WriteLine(balance*(vat/100D));
            Console.WriteLine(balance*percentVAT);

            string firstName = "Mausam";
            string number = "0127829";
            int age1=21;
            Console.WriteLine(firstName);
            Console.WriteLine(number);
            Console.WriteLine(age1);

            Console.WriteLine("Hello My name is Mausam");
            Console.WriteLine("What is your name? ");
            string userName=Console.ReadLine();
            Console.WriteLine("Your Name is "+ userName);
            Console.WriteLine("What is your age?");
            string userAge=Console.ReadLine();
            int intage1=Convert.ToInt32(userAge);
            Console.WriteLine("Your Name is " + userName +" and Your age is "+ intage1);
            Console.ReadLine();
        }
    }
}
