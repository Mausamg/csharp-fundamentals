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
        static void Main(string[] args)
        {
            ReadTriangle();
        }
    }
}
