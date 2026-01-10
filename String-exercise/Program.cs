using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_exercise
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            /*
        * Assign a string variable with your full name.
        * Print in order
        * Print in reverse order
        */

            Console.WriteLine("Please enter your full name:");
            string fullName = Console.ReadLine();
            Console.WriteLine(fullName);
            Console.WriteLine(fullName.Length);
            if (!string.IsNullOrEmpty(fullName))
            {
                Console.WriteLine(fullName[0]);
            }


            Console.WriteLine("Your name in reverse order is:");
            Console.WriteLine(new string(fullName.Reverse().ToArray()));


            /*
             * Ask user to enter password and store 
             * Ask user to enter password again and store
             * Check if both passwords match
             *            if match print "Password set successfully"
             *            if not match print "Passwords do not match, try again"
             */

            Console.WriteLine("Enter your Password : ");
            string password1 = Console.ReadLine();

            Console.WriteLine("Enter your Password again : ");
            string password2 = Console.ReadLine();

            if (!password1.Equals(string.Empty))
            {
                if (password1.Length >= 8)
                {
                    if (!password2.Equals(string.Empty))
                    {
                        if (password1.Equals(password2))
                        {
                            Console.WriteLine("Password set sucessfully");
                        }
                        else
                        {
                            Console.WriteLine("Passwords do not match, try again");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a confirmation password");
                    }
                }
                else
                {
                    Console.WriteLine("Password must be at least 8 characters long");
                }
            }
                
            else
            {
                Console.WriteLine("Please enter a password");
            }
            Console.ReadLine();
        }
    }
}
