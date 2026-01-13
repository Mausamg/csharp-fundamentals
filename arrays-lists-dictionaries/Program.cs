using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_lists_dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays in C#
             Console.WriteLine("Enter the size of Array : ");
            int i = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[i];

            for (int j = 0; j < i; j++)
            {
                Console.WriteLine("Enter the element {0} : ", j + 1);
                numbers[j] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("The elements in the array are :");
            for (int j = 0; j < i; j++)
            {
                Console.Write($" {numbers[j]}");
            }
            Console.WriteLine("\n The array elements are :");
            foreach (int j in numbers)
            {
                Console.Write($"{j}");
            }

            int sum = 0;
            int[] angles = new int[3];
            for (int i = 0; i < angles.Length; i++)
            {
                Console.WriteLine($"Enter the  angle {i + 1}:");
                angles[i] = Convert.ToInt32(Console.ReadLine());
                sum += angles[i];
            }
            Console.WriteLine("The sum of angles is : " + sum);
            if (angles.Length != 0)
            {
                if (sum == 180)
                {
                    Console.WriteLine("The angles  form a triangle");
                }
                else
                {
                    Console.WriteLine("Invalid, The total sum of angles must be 180.");

                }
            }
            else
            {
                Console.WriteLine("The angles doesnot form a triangle");
            }

            //Array Sorting
            Array.Sort(angles);
            Console.WriteLine("The sorted angles are : ");
            foreach (int i in angles)
            {
                Console.Write($"{i} ");

            }


            //Array Reverse
            //Array.Reverse(angles);
            Console.Write("\n The reversed angles are : ");
            foreach (int i in angles)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\nEnter a number to search :");
            int search = Convert.ToInt32(Console.ReadLine());

            int position = Array.IndexOf(angles, search, 1, 2);
            if (position > -1)
            {
                Console.WriteLine($"The {search} number has been found in postion{position + 1}");
            }
            else
            {
                Console.WriteLine($"{search} not found");
            }


            //Lists in C#
            int[] numbers1 = new int[4]
            {
                1, 2, 3,4
            };
            //numbers1[0] = 1;
            //numbers1[1] = 2;
            //numbers1[2] = 3;
            List<int> num1 = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter the element {0} : ", i + 1);
                num1.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("List Element");
            for (int i = 0; i < num1.Count; i++)
            {
                Console.Write(num1[i]);
            }
            Console.WriteLine();
            //Dictionary in C#
            Dictionary<int, string> names = new Dictionary<int, string>
            {
                //KeyValue pairs
                {1, "Alice"  },
                {2, "Bob" },
                {3, "Charlie"
            }
            };
            //names.Add(1, "Alice");
            //names.Add(2, "Bob");
            //names.Add(3, "Charlie");

            for(int i=1; i <= names.Count; i++)
            {
                //Console.WriteLine("Key: {0}, Value: {1}", i, names[i]);
                KeyValuePair<int, string> pair = names.ElementAt(i);
                Console.WriteLine("Key: {0}, Value: {1}", pair.Key, pair.Value);
            }

            foreach(var pair in names)
            {
                Console.WriteLine("Key: {0}, Value: {1}", pair.Key, pair.Value);
            }

            Dictionary<string,string> teachers = new Dictionary<string, string>
            {     {"Maths", "Mr. Smith" },
                {"Science", "Ms. Johnson" },
                {"History", "Mr. Brown" }
            };

            if (teachers.TryGetValue("Science", out string teacherName))
            {
                Console.WriteLine("The teacher for Science is: " + teacherName);
            }
            else
            {
                Console.WriteLine("Subject not found.");
            }
        }
    }
}
