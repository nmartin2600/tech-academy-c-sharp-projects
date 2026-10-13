using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIterate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //**ASSIGNMENT PART 1**//

            Console.WriteLine("Assignment Part 1\n");
            // Create String array of size 4
            String[] names = { "Nick", "Matt", "Corey", "Joe" };
            // Prompt user to input text to append to each element in the array
            Console.WriteLine("Please enter some text to append to the elements of the String array:");
            // Store input as string
            string append = Console.ReadLine();
            Console.WriteLine("\n");

            // Loop through the array and append the text to each element
            for (int i = 0; i < names.Length; i++)
            {
                names[i] += append;
            }
            // Loop through the array again and print each element
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\n");

            //**ASSIGNMENT PART 2**//

            Console.WriteLine("Assignment Part 2\n");
            /* Create an infinite while loop
            while(true)
            {
                Console.WriteLine("This is an infinite while loop.");
            }
            */

            // Fix the infinite loop by breaking out after first iteration
            while (true)
            {
                Console.WriteLine("This is the fixed while loop.");
                break;
            }

            Console.WriteLine("\n");

            //**ASSIGNMENT PART 3**//

            Console.WriteLine("Assignment Part 3\n");
            // Create 2 int to be used as loop indices
            int begin = 5;
            int end = 10;

            Console.WriteLine("For loop using < operator:\n");
            // For loop using < operator for iteration conditions
            for (int i = begin; i < end; i++)
            {
                Console.WriteLine("Current value of i: " + i);
            }
            Console.WriteLine("\n");

            Console.WriteLine("For loop using <= operator:\n");
            // For loop using <= operator for iteration conditions
            for (int i = begin; i <= end; i++)
            {
                Console.WriteLine("Current value of i: " + i);
            }

            Console.WriteLine("\n");

            //**ASSIGNMENT PART 4**//

            Console.WriteLine("Assignment Part 4\n");

            // Create a list of type String and add 4 values to it
            List<String> strList = new List<String>();
            strList.Add("One");
            strList.Add("Two");
            strList.Add("Three");
            strList.Add("Four");
            // Store list size as int to use in loop
            int length = strList.Count;

            // Prompt user for text to search for within the list
            Console.WriteLine("Please enter the text to search for in the String list:");
            string query = Console.ReadLine();
            Console.WriteLine("\n");

            // Loop through the list and check if any elements have the same value as search query
            for (int i = 0; i < length; i++)
            {
                // If the current element matches the query
                if (strList[i] == query)
                {
                    // Print the index of that element and break from the loop
                    Console.WriteLine("The index of the element in the list matching the search query is: " + i);
                    break;
                }
                // If this is the last element in the list and there is no match
                else if (i == length - 1)
                {
                    // Notify the user that there was no match and break from the loop
                    Console.WriteLine("The provided query was not found on the list");
                    break;
                }
            }

            Console.WriteLine("\n");

            //**ASSIGNMENT PART 5**//

            Console.WriteLine("Assignment Part 5\n");

            // Create a list of type String and add 4 values to it
            List<String> strList2 = new List<String>();
            // First 2 values are identical
            strList2.Add("Hello");
            strList2.Add("Hello");
            strList2.Add("World");
            strList2.Add("Goodbye");
            // Store list size as int to use in loop
            int length2 = strList2.Count;

            // Prompt user for text to search for within the list
            Console.WriteLine("Please enter the text to search for in the String list:");
            string query2 = Console.ReadLine();
            Console.WriteLine("\n");
            
            // Store number of matches as int
            int matches = 0;

            // Loop through the list and check if any elements have the same value as search query
            for (int i = 0; i < length2; i++)
            {
                // If the current element matches the query
                if (strList2[i] == query2)
                {
                    matches += 1;
                    Console.WriteLine("The index of the element in the list matching the search query is: " + i);
                }
                // If the current element does not match the query
                else
                {
                    // If this is the last element in the list
                    if (i == length2 - 1)
                    {
                        // If there was a match, just break from the loop
                        if (matches > 0)
                        {
                            break;
                        }
                        // If there were no matches, notify user and break from loop
                        else
                        {
                            // Notify the user that there was no match and break from the loop
                            Console.WriteLine("The provided query was not found on the list");
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("\n");

            //**ASSIGNMENT PART 6**//

            Console.WriteLine("Assignment Part 6\n");

            // Create a list of type String and add 4 values to it
            List<String> strList3 = new List<String>();
            // Third and last values are identical
            strList3.Add("A");
            strList3.Add("B");
            strList3.Add("C");
            strList3.Add("D");
            strList3.Add("C");

            // HashSet collection of type String used to track unique values
            HashSet<String> seenValues = new HashSet<string>();

            // Loop through each element in the list
            foreach(string letter in strList3)
            {
                // If the value is a duplicate, notify user
                // .Add() returns false if value already exists in HashSet
                if (!seenValues.Add(letter))
                {
                    Console.WriteLine(letter + " - this item is a duplicate");
                }
                // Else the value is not a duplicate, notify user that it's unique
                else
                {
                    seenValues.Add(letter);
                    Console.WriteLine(letter + " - this item is unique");
                }
            }

            Console.WriteLine("\n");

            //**PROGRAM EXIT**//

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
