using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndMethods
{
    class Test
    {
        public static void SampleMethod()
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

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Enter the {i + 1} array elememt :");
                arrayNum[i] = Convert.ToInt32(Console.ReadLine());

            }
            int counter = 0;
            Console.WriteLine("Using foreach loop: ");
            foreach (int n in arrayNum)
            {
                Console.WriteLine($"The array element {counter + 1} is : {n}");
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


        //function parameter
        static int AddNumbers(int a, int b)
        {
            return a + b;
        }
        static int MultNumbers(int a, int b)
        {
            return a * b;
        }

        static int ReadInt()
        {
            Console.WriteLine("Enter two numbers to add: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            return AddNumbers(num1, num2);
        }

        static int Add(int a, [Optional] int b)
        {
            return a + b;
        }

        //Named Parameters
        static void PrintDetails(string name, int age, string address)
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Address: {address}");
        }

        //Out Parameter 
        static bool testOut(out int num)
        {
            num = 5;
            return true;
        }

        static bool findItem(string s, List<string> list, out int index)
        {
            index = -1;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToLower().Equals(s.ToLower()))
                {
                    index = i;
                    return true;
                }
                
            }
            return false;
        }
        static bool TryParse(string s, out int result)
        {
            result = 0;
            return false;
        }
        static void Main(string[] args)
        {
            //ExampleMethod();

            Test.SampleMethod();

            bool success = int.TryParse("123", out int result);
            Console.WriteLine(result);
            Console.WriteLine(success);

            //PrintArray();
            Console.Title = $"{MyName()} - {MyAge()}";
            string output = $"Hello, My name is {MyName()} and I am {MyAge()} years old.";
            Console.WriteLine(output);


            int sum = ReadInt();
            Console.WriteLine($"The returned sum is: {sum}");

            Console.WriteLine(Add(10));
            Console.WriteLine(MultNumbers(sum, 10));

            PrintDetails("Mausam", 21,"KTM");

            int n = 0;
            bool success2=testOut(out n);
            Console.WriteLine(n+" "+success2);
            //int.TryParse("456", out int result2);

            List<string> shoppingList = new List<string>
            {
                "Coffee","Milk"
            };
            Console.WriteLine(shoppingList.IndexOf("Milk"));
            Console.WriteLine("List item"+findItem("coffeer", shoppingList, out int index));
            Console.ReadLine();
        }
    }
}

