using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initial message on program start
            Console.WriteLine("Anonymous Income Comparison Program\n");

            // Prompt user for hourly pay rate of Person 1
            Console.WriteLine("Person 1");
            Console.WriteLine("Enter your hourly rate:");
            // Save input as a converted double
            double p1Rate = Convert.ToDouble(Console.ReadLine());
            // Prompt user for hours worked per week
            Console.WriteLine("Enter your hours worked per week:");
            // Save input as a converted int
            int p1Hours = Convert.ToInt32(Console.ReadLine());
            // Annual Income = Hourly Rate * Hours Worked per Week * 52 Weeks
            // There are 52 weeks in a year, so we multiply
            // the weekly pay by that to get the annual income
            double p1Income = p1Rate * p1Hours * 52;

            Console.WriteLine("\n");

            // Repeat the same steps as for Person 1
            Console.WriteLine("Person 2");
            Console.WriteLine("Enter your hourly rate:");
            double p2Rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your hours worked per week:");
            int p2Hours = Convert.ToInt32(Console.ReadLine());
            double p2Income = p2Rate * p2Hours * 52;

            Console.WriteLine("\n");

            // Display the annual salaries of each person
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine("$" + Convert.ToString(p1Income));
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine("$" + Convert.ToString(p2Income));

            Console.WriteLine("\n");

            // Display which person makes more money by boolean comparison of their incomes
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool moreMoney = p1Income > p2Income;
            Console.WriteLine(moreMoney.ToString());

            Console.WriteLine("\n");
            // Program will not exit until user presses a key
            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }
    }
}
