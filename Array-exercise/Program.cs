using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create two list with integer data type, one for even numbers and one for odd numbers.
             * loop from 0-20
             * if number is even, add to even list
             * if number is odd, add to odd list
             * 
             * print both lists to console
             * */

            List<int> odd = new List<int>();
            List<int> even = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);

                }
                else
                {
                    odd.Add(i);
                }
            }
            Console.Write("Even numbers:");

            foreach (var num in even)
            {
                Console.Write(num);
            }

            Console.Write("\nOdd numbers:");

            foreach (var num in odd)
            {
                Console.Write(num);
            }

            Console.WriteLine();
            /*
             * Define and init two inters(num, length)
             * (7, 5)->[7,14,21,28,35]
             * Create int array with size of length
             * loop through and insert the loop counter x num into array
             * print the final array
             * */

            int num1 = 7;
            int length = 5;
            int[] result = new int[length];

            int counter = 0;
            for (int i = 1; i <= result.Length; i++, counter++)
            {
                result[counter] = num1 * i;
            }
            foreach (var num2 in result)
            {
                Console.Write(num2+" ");
            }
        }
    }
}
