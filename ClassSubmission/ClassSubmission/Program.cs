using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of Manager class
            Manager mng = new Manager();
            // Prompt user for a number and store as converted int
            Console.WriteLine("Please enter a whole number for the class method:");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");
            // Call the class method on provided number
            mng.DivideInHalf(num);
            Console.WriteLine("\n");

            // Method call on static class
            MyStaticClass.Message();
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
