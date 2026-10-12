using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create String array of size 4
            String[] strArray = { "Nick", "Bob", "Joe", "Matt" };
            int strArraySize = strArray.Length;
            // Prompt user to enter index of String array to display and convert to int
            Console.WriteLine("Please enter the index of the String array value to display (0-3):");
            int i = Convert.ToInt32(Console.ReadLine());

            // If the provided index exists in the array
            if (i >= 0 && i < strArraySize)
            {
                // Display the value of the index in the array
                Console.WriteLine("The value of the String array at index " + i + " is: " + strArray[i]);
                Console.WriteLine("\n");
            }
            // If the provided index does not exist in the array
            else
            {
                // Notify user and terminate the program
                Console.WriteLine("\n");
                Console.WriteLine("The entered index does not exist in the String array. The program will now exit.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                return;
            }

            // Create int array of size 4
            int[] intArray = { 10, 11, 12, 13 };
            int intArraySize = intArray.Length;
            // Prompt user to enter index of int array to display and convert to int
            Console.WriteLine("Please enter the index of the int array value to display (0-3):");
            i = Convert.ToInt32(Console.ReadLine());

            // If the provided index exists in the array
            if (i >= 0 && i < intArraySize)
            {
                // Display the value of the index
                Console.WriteLine("The value of the int array at index " + i + " is: " + intArray[i]);
                Console.WriteLine("\n");
            }
            // If the provided index does not exist in the array
            else
            {
                // Notify user and terminate the program
                Console.WriteLine("\n");
                Console.WriteLine("The entered index does not exist in the int array. The program will now exit.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                return;
            }

            // Create String list of size 4
            List<String> strList = new List<string>();
            strList.Add("Corey");
            strList.Add("Tim");
            strList.Add("Erik");
            strList.Add("Donovan");
            int strListSize = strList.Count;
            // Prompt user to enter index of String array to display and convert to int
            Console.WriteLine("Please enter the index of the String list value to display (0-3):");
            i = Convert.ToInt32(Console.ReadLine());

            // If the provided index exists in the list
            if (i >= 0 && i < strListSize)
            {
                // Store value at index as string variable
                string listValue = strList[i];
                // Display the value
                Console.WriteLine("The value of the String list at index " + i + " is: " + listValue);
                Console.WriteLine("\n");
            }
            // If the provided index does not exist in the list
            else
            {
                // Notify user and terminate the program
                Console.WriteLine("\n");
                Console.WriteLine("The entered index does not exist in the String list. The program will now exit.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                return;
            }

            // Prompt user to press any key to exit the program
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
