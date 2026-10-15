using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Ask user for a number to pass into the IntClass methods and store as int
                Console.WriteLine("Please enter a whole number to do math operations on:");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                // Create new instance of IntClass to perform math operations
                IntClass myClass = new IntClass();
                // Pass number to each method and print the result
                Console.WriteLine("Performing calculations with each method on the given number...");
                Console.WriteLine("Result of method one: " + myClass.methodOne(num));
                Console.WriteLine("Result of method two: " + myClass.methodTwo(num));
                Console.WriteLine("Result of method three: " + myClass.methodThree(num));
            }
            // If the user does not enter a whole number
            catch (FormatException ex)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Please enter a whole number.");
            }
            // If there is any other type of error
            catch(Exception ex)
            {
                Console.WriteLine("\n");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n");
            Console.WriteLine("Please press any key to exit...");
            Console.ReadLine();
        }
    }
}
