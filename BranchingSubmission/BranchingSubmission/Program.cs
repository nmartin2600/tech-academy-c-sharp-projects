using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initial message on program start
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");

            // Prompt user for package weight and store as int
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());
            
            // If weight is greater than 50, display error message and exit program
            if (weight > 50)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                return;
            }
            // Else print a newline
            else
            {
                Console.WriteLine("\n");
            }

            // Prompt user for package width, height, length and store as int
            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            int dimensionTotal = width + height + length;
            // If sum of dimensions greater than 50, display error message and exit program
            if (dimensionTotal > 50)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                return;
            }
            // Else print a newline
            else
            {
                Console.WriteLine("\n");
            }

            // Calculate quote as decimal by taking product of dimensions and weight, then dividing by 100
            decimal quote = (length * width * height) * weight / 100;
            // Display quote rounded to 2 places
            Console.WriteLine("Your estimated total for shipping this package is: "
                + "$" + Math.Round(quote, 2));
            Console.WriteLine("Thank you!\n");

            // Program will wait for key press before exiting
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
