using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    internal abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // SayName() should print FirstName and LastName to console
        // Abstract method must be implemented by child class
        public abstract void SayName();
    }
}
