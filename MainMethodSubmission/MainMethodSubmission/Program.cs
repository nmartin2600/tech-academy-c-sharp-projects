using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instance of class IntManager for the 3 math operation functions
            IntManager manager = new IntManager();
            Console.WriteLine("First method result: " + manager.Operation(1));
            Console.WriteLine("Second method result: " + manager.Operation(3.67m));
            Console.WriteLine("Third method result: " + manager.Operation("777"));

            Console.WriteLine("\n");
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
