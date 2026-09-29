using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initial message on program start
            Console.WriteLine("The Tech Academy\n");
            Console.WriteLine("Student Daily Report\n\n");

            // Ask for user's name and save input as string
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();
            Console.WriteLine("\n");

            // Ask for user's current course and save input as string
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("\n");

            // Ask for page number of current course and save input as converted int
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            // Ask user to specify any help needed and save input as converted bool
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            bool help = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("\n");

            // Ask user to specify positive experiences and save input as string
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string experiences = Console.ReadLine();
            Console.WriteLine("\n");

            // Ask user to specify feedback and save input as string
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("\n");

            // Ask user to specify how many hours worked and save input as converted int
            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            // Ending message, program will wait for input before closing
            Console.WriteLine("Thank you for your answers, an instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
