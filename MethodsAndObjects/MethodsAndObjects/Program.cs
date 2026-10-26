using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new object of Employee class
            Employee emp = new Employee();
            // Initialize properties of object
            emp.FirstName = "Nicholas";
            emp.LastName = "Martin";
            // Call method inherited from Person class
            emp.SayName();

            Console.WriteLine("\n");
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
