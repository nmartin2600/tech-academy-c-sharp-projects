using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    internal class Manager
    {
        // Add 1 to sum of the provided int and return result
        // num2 parameter is optional
        public int Operation(int num1, int num2 = 0)
        {
            return num1 + num2 + 1;
        }
    }
}
