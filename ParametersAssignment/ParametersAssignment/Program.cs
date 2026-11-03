using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create two Employee objects, one with generic type as string and the other int
            // and add values to List property Things
            Employee<string> first = new Employee<string>(1, "Nicholas", "Martin");
            first.Things = new List<string>();
            first.Things.Add("Hello");
            first.Things.Add("World");

            Employee<int> second = new Employee<int>(2, "John", "Smith");
            second.Things = new List<int>();
            second.Things.Add(1);
            second.Things.Add(2);

            Console.WriteLine("Printing values from first object...");

            // Loop through each string value in List<string> property Things
            // from first object and print value
            foreach (string s in first.Things)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\n");
            Console.WriteLine("Printing values from second object...");

            // Loop through each int value in List<int> property Things 
            // from second object and print value
            foreach (int i in second.Things)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n");
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}