using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instance of Manager class to use math operation function
            Manager mng = new Manager();
            // Call class method with test parameter values
            Console.WriteLine("Calling class method...");
            Console.WriteLine("Result of method: " + mng.Operation(1,2));
            Console.WriteLine("\n");

            // Prompt user to enter 2 whole numbers and store as int
            Console.WriteLine("Please enter up to 2 whole numbers, one at a time");
            Console.WriteLine("The second number can be ommitted by pressing enter when prompted\n");
            Console.WriteLine("First number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            // Second number is optional
            int num2;
            Console.WriteLine("Second number:");

            // If the user presses the enter key when prompted for second number
            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                // Display result of class method passing in only num1
                Console.WriteLine("\n");
                Console.WriteLine("Testing the method with the one provided number...");
                Console.WriteLine("Result of method: " + mng.Operation(num1));
            }
            // If the user actually enters a second number
            else
            {
                // Display result of class method passing in both num1 and num2
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                Console.WriteLine("Testing the method with the provided numbers...");
                Console.WriteLine("Result of method: " + mng.Operation(num1, num2));
            }

            Console.WriteLine("\n");
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
