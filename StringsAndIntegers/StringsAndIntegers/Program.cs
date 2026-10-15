using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of type int and add 4 values
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            // Store list size as int to use in for loop
            int size = numbers.Count;
     
            try
            {
                // Prompt user to enter the divisor for each list element and store as int
                Console.WriteLine("Please enter a whole number to divide each element in the int list by:");
                int divisor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Starting the division...\n");

                // Loop through the list, divide each element by the divisor, and print result
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine(numbers[i] / divisor);
                }
            }
            // If the user does not enter a non-zero whole number
            catch(FormatException ex)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Please enter a whole number.");
            }
            // If the user enters 0
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("\n");
                Console.WriteLine("You cannot divide by 0.");
            }
            // If there are any other errors
            catch (Exception ex)
            {
                Console.WriteLine("\n");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n");
            Console.WriteLine("Exited try/catch block.");
            Console.WriteLine("Press any key to exit the program...");
            Console.ReadLine();
        }
    }
}
