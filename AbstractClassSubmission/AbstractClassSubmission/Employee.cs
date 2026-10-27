using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    internal class Employee : Person
    {
        // Implement SayName() method from Person class
        public override void SayName()
        {
            Console.WriteLine("Full Name: " + this.FirstName + " " + this.LastName);
        }
    }
}
