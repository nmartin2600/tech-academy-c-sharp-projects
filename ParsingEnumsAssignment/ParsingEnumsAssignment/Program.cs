using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    internal class Program
    {
        // enum property to store days of week as constant values
        enum DaysOfWeek
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a day of the week:");

            try
            {
                // Store user input as string
                string entered = Console.ReadLine();
                Console.WriteLine("\n");
                
                // If the input can be parsed as enum value
                if ( Enum.TryParse<DaysOfWeek>(entered, out DaysOfWeek result) )
                {
                    // Store input as enum value and print to console
                    DaysOfWeek day = result;
                    Console.WriteLine("The the entered day was: " + day);
                }
                // Else throw an error
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
            // Display error message if caught
            catch (Exception ex) 
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
