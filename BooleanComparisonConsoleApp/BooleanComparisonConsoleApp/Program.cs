using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanComparisonConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for a number from 0 to 10 and store as int
            Console.WriteLine("Enter a number from 0 to 10:");
            int num = Convert.ToInt32(Console.ReadLine());
            // bool to determine if the entered number is valid
            bool isValidNum = false;
            
            // Loop while entered number is invalid
            while (isValidNum == false)
            {
                // If num is between 0 and 10 inclusive, display it and break out of loop
                if (0 <= num &&  num <= 10)
                {
                    Console.WriteLine("You entered: " + num);
                    break;
                }
                // Else prompt to enter another number
                else
                {
                    Console.WriteLine("Invalid number. Please enter a number from 0 to 10:");
                    num = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\n");

            // Prompt user for a number from 11 to 20 and store as int
            Console.WriteLine("Enter a number from 11 to 20:");
            num = Convert.ToInt32(Console.ReadLine());

            // Do these comparisons once then loop while entered number is invalid
            do
            {
                // If num is between 11 and 20 inclusive, display it and break out of loop
                if (11 <= num && num <= 20)
                {
                    Console.WriteLine("You entered: " + num);
                    break;
                }
                // Else prompt to enter another number
                else
                {
                    Console.WriteLine("Invalid number. Please enter a number from 11 to 20:");
                    num = Convert.ToInt32(Console.ReadLine());
                }

            } while (isValidNum == false);

            // Program will wait for key press before exiting
            Console.WriteLine("\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
