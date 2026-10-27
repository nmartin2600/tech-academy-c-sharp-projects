using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create new object of class Employee and initialize properties
            Employee emp = new Employee();
            emp.FirstName = "Sample";
            emp.LastName = "Student";
            // Call function that will print full name of employee
            emp.SayName();

            Console.WriteLine("\n");
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
