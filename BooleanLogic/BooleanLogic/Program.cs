using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initial message on program start
            Console.WriteLine("Car Insurance Approval Screening\n");

            // Prompt user for their age and store as converted int
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            // Prompt user to specify if they have a DUI on record and store as converted bool
            Console.WriteLine("Have you ever had a DUI?");
            bool hasDUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("\n");

            // Prompt user to specify how many speeding tickets they have and store as converted int
            Console.WriteLine("How many speeding tickets do you have?");
            int numTickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            // Determine if applicant qualifies for car insurance based on answers to prompts
            Console.WriteLine("Do you qualify for car insurance?");
            // Qualifies only if age over 15, no DUIs, and no more than 3 speeding tickets
            if (age > 15 && hasDUI == false && numTickets <= 3)
            {
                Console.WriteLine(true);
            }
            // Otherwise does not qualify
            else
            {
                Console.WriteLine(false);
            }

            Console.WriteLine("\n");
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
