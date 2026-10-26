using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    internal class Manager
    {
        // Takes int as input and displays the value divided by 2
        public void DivideInHalf(int num)
        {
            Console.WriteLine("The provided number divided in half equals: " + num / 2);
        }

        // Overloaded version of method that takes double as input
        public void DivideInHalf(double num)
        {
            Console.WriteLine("The provided number divided in half equals: " + num / 2);
        }

        // Takes str as input and displays value as int if it can be converted
        // Otherwise, display that it could not be converted
        public void ParseNumString(string str)
        {
            if (int.TryParse(str, out int result))
            {
                Console.WriteLine("The provided string converted to int is: " + result);
            }
            else
            {
                Console.WriteLine("The provided string could not be converted to int.");
            }
        }
    }
}
