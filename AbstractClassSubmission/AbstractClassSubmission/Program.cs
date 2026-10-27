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

            // Create new object of interface type IQuittable and call Quit() method as implemented in Employee class
            IQuittable quittable = new Employee();
            quittable.Quit();
        }
    }
}
