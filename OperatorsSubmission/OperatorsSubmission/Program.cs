using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create 2 Employee objects and assign values to their properties
            Employee first = new Employee(1, "Nicholas", "Martin"),
                     second = new Employee(2, "John", "Smith");

            // Check if the objects are equal using overloaded == operator
            Console.WriteLine("Are the two Employee objects equal (==)?");
            Console.WriteLine(first == second);
            Console.WriteLine("\n");

            // Check if the objects are not equal using overloaded != operator
            Console.WriteLine("Are the two Employee objects not equal (!=)?");
            Console.WriteLine(first != second);
            Console.WriteLine("\n");

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
