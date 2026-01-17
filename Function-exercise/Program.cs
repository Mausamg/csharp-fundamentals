using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_exercise
{
    internal class Program
    {
        static void AreaTriangle(int len, int bre)
        {

            double AreaTriangele = 0.5 * (len * bre);
            Console.WriteLine("The Area of Triangle is "+AreaTriangele);
        }

        static void ReadTriangle()
        {
            Console.WriteLine("Enter the length of the Triangle :");
            int len=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Height of the Triangle :");
            int bre=Convert.ToInt32(Console.ReadLine());

            AreaTriangle(len, bre);
        }

        static int SumArray(int[] numbers)
        {
            if (numbers.Length > 0)
            {
            int total = 0;
                foreach (int number in numbers)
                {
                    total += number;
                }
                return total;
            }
            return -1;
        }
        static bool SumArray(int[] numbers, out int total)
        {
            total = 0;
            if (numbers.Length > 0)
            {
            foreach (int number in numbers)
            {
                total += number;
            }
                return true;
            }
            return false;
        }

        static void ReadArray()
        {
            Console.WriteLine("Enter the size of the Array :");
            int size=Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[size];
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter {i+1} Array element :");
                numbers[i]=Convert.ToInt32(Console.ReadLine());
            }
            int result=SumArray(numbers);
            if (SumArray(numbers, out int total))
            {
                Console.WriteLine("The total sum of Array elements is " + total);

            }
            else
            {
                Console.WriteLine("We cannot add the empty Array.");
            }
        }
        static void Main(string[] args)
        {
            //ReadTriangle();
            ReadArray();
        }
        

    }
}
