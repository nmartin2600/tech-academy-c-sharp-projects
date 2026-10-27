using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    internal class Employee : Person, IQuittable
    {
        // Implement SayName() method from Person class
        public override void SayName()
        {
            Console.WriteLine("Full Name: " + this.FirstName + " " + this.LastName);
        }

        // Implement Quit() method from IQuittable interface
        public void Quit()
        {
            Console.WriteLine("\n");
            Console.WriteLine("This is the Quit() method as implemented in class Employee.");
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
