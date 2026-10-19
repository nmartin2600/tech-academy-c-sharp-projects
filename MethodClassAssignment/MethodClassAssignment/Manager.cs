using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    internal class Manager
    {
        // Add 1 to num1 and print the value of num2
        public void Operation(int num1, int num2)
        {
            num1 += 1;
            Console.WriteLine("Result of method: " + num2);
        }
    }
}
