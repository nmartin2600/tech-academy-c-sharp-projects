using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create List of 10 Employee objects,
            // with two of them having the first name "Joe"
            List<Employee> employees = new List<Employee>()
            {
                new Employee(1, "Joe", "Pannozzo"),
                new Employee(2, "Joe", "Biden"),
                new Employee(3, "Nick", "Martin"),
                new Employee(4, "Matt", "Janisch"),
                new Employee(5, "Witch", "Wichman"),
                new Employee(6, "Bob", "Martinez"),
                new Employee(7, "Erik", "Medeiros"),
                new Employee(8, "Corey", "Bedore"),
                new Employee(9, "Austin", "Connors"),
                new Employee(10, "John", "Fowler")
            };

            Console.WriteLine("Created list of 10 Employee objects");

            // Create List of Employee objects to store
            // those that have first name "Joe"
            List<Employee> joe = new List<Employee>();

            // Loop through employees and add to
            // List if first name is "Joe"
            foreach (Employee e in employees)
            {
                if (e.FirstName == "Joe")
                {
                    joe.Add(e);
                }
            }

            Console.WriteLine("Created list of employees with first name Joe");

            // Create another List that's the same as the
            // previous, but populate using lambda expression
            List<Employee> joe2 = new List<Employee>();

            employees.ForEach(e =>
            {
                if (e.FirstName == "Joe")
                { joe2.Add(e); }
            });

            Console.WriteLine("Created list of employees with first name Joe using lambda");

            // Create another List of all employees
            // with an Id number greater than 5
            // using lambda expression
            List<Employee> greaterThanFive = employees
                    .Where(e => e.Id > 5).ToList();
            Console.WriteLine("Created list of employees with ID number greater than 5 using lambda");

            Console.WriteLine("\n");
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
