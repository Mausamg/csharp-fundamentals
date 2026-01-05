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
            Console.WriteLine("Name: " + name + ", Grade: " + grade);

            string textAge= "21";
            int agenum= Convert.ToInt32(textAge);
            Console.WriteLine(agenum);

            string textBigNumber= "12345678901234";
            long bigNum= Convert.ToInt64(textBigNumber);
            Console.WriteLine(bigNum);

            string textNegative= "-3.14";
            double negNum= Convert.ToDouble(textNegative);
            Console.WriteLine(negNum);

            string textPrecision= "19.99";
            float piNum= Convert.ToSingle(textPrecision);
            Console.WriteLine(piNum);

            string textMoney= "19.99";
            decimal moneyNum= Convert.ToDecimal(textMoney);
            Console.WriteLine(moneyNum);

            bool isMale= true;
            bool isAdult= false;
            Console.WriteLine("Is Male: " + isMale + ", Is Adult: " + isAdult);
            Console.ReadLine();
        }
    }
}
