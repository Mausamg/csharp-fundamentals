using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndMethods
{
    class Test
    {
        public  static void SampleMethod()
        {
            Console.WriteLine("This is a sample method in Test class.");
        }
    }


        internal class Program
        {
            static void ExampleMethod()
            {
                Console.WriteLine("This is an example method.");
            }

        static void PrintArray()
        {
            Console.WriteLine("Enter the size of array : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arrayNum = new int[num];
            
            for(int i=0;i<num;i++)
            {
                Console.WriteLine($"Enter the {i + 1} array elememt :");
                arrayNum[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            int counter = 0;
            Console.WriteLine("Using foreach loop: ");
            foreach (int n in arrayNum)
            {
                Console.WriteLine($"The array element {counter+1} is : {n}");
                counter++;
            }


            Console.WriteLine("Using for loop: ");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"The array element {i + 1} is : {arrayNum[i]}");
            }
        }
        static string MyName()
        {
            return "Mausam G";
        }

        static int MyAge()
        {
            return 21;
        }

            static void Main(string[] args)
            {
                ExampleMethod();
                
                Test.SampleMethod();
                
            bool success = int.TryParse("123", out int result);
            Console.WriteLine(result);
            Console.WriteLine(success);

            //PrintArray();
            Console.Title= $"{MyName()} - {MyAge()}";
            string output=$"Hello, My name is {MyName()} and I am {MyAge()} years old.";
            Console.WriteLine(output);
                Console.ReadLine();
            }
        }
    }

