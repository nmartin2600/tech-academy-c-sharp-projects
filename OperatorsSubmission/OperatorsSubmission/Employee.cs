using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmission
{
    internal class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload == operator to check if 2 Employee objects are equal
        // by comparing their Id property
        public static bool operator ==(Employee first, Employee second)
        {
            // Return true if values of Id are equal, otherwise return false
            return first.Id == second.Id;
        }

        // Overloading == requires that != operator is also overloaded
        public static bool operator !=(Employee first, Employee second)
        {
            // Return true if values of Id are not equal, otherwise return false
            return !(first.Id == second.Id);
        }
    }
}
