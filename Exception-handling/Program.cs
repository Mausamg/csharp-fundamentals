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
            bool looping = true;

            while (looping)
            {
            try
            {
            Console.WriteLine("Enter a number :");
            int num =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num);
                    looping =false;
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
                Console.WriteLine("Good Bye!");

        }
    }
}
