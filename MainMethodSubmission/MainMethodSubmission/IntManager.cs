using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    internal class IntManager
    {
        // Add 1 to given int and return the result
        public int Operation(int num)
        {
            return num + 1;
        }

        // Subtract 1 from given decimal, convert to int and return the result
        public int Operation(decimal num)
        {
            return Convert.ToInt32(num - 1);

        }

        // Try to convert given str to int, if possible then multiply by 3 and return result
        // Otherwise, return 0
        public int Operation(String str)
        {
            if (int.TryParse(str, out int result))
            {
                return result * 3;
            }
            else
            {
                return 0;
            }
        }
    }
}
