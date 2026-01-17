using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.FormatException
            //System.OverflowException
            try
            {
            Console.WriteLine("Enter a number :");
            int num =Convert.ToInt32(Console.ReadLine());

            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Please Enter the value less than 2 billion!");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Please Enter the valid number!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some other exception occured : " + ex.Message);
            }

        }
    }
}
