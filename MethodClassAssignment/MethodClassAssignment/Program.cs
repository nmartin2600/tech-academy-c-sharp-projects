using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instance of class Manager to use math operation method
            Manager mng = new Manager();
            Console.WriteLine("Testing class method passing in 2 numbers...");
            // Operation() is of type void and writes to the console
            mng.Operation(6,7);

            Console.WriteLine("\n");
            Console.WriteLine("Testing class method with named parameters...");
            // Same method call but with named parameters
            mng.Operation(num1: 50, num2: 60);

            Console.WriteLine("\n");
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
