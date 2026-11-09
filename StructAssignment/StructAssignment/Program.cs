using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    internal class Program
    {
        // public struct that has decimal property
        public struct Number
        {
            public decimal Amount {  get; set; }
        }

        static void Main(string[] args)
        {
            // Create new object of type Number
            Number number = new Number();
            // Set Amount property to decimal value
            number.Amount = 6.78m;
            // Print value to console
            Console.WriteLine(number.Amount + "\n");
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
