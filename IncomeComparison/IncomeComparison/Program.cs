using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program Title
            Console.WriteLine("Anonymous Income Comparison Program.");

            // Person 1 Input
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate: ");
            int hourlyRate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week: ");
            int hoursWeekly1 = Convert.ToInt32(Console.ReadLine());
            int combinedInfo1 = hourlyRate1 * hoursWeekly1;
            Console.WriteLine(combinedInfo1);

            // Person 2 input
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate: ");
            int hourlyRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week: ");
            int hoursWeekly2 = Convert.ToInt32(Console.ReadLine());
            int combinedInfo2 = hourlyRate2 * hoursWeekly2;
            Console.WriteLine(combinedInfo2);

            // Multiplying the total of hours worked and hourly rate by num of weeks a year.
            Console.WriteLine("Annual salary of Person 1: ");
            int salaryPerson1 = combinedInfo1 * 52;
            Console.WriteLine(salaryPerson1);

            // Multiplying the total of hours worked and hourly rate by num of weeks a year.
            Console.WriteLine("Annual salart of Person 2: ");
            int salaryPerson2 = combinedInfo2 * 52;
            Console.WriteLine(salaryPerson2);

            Console.WriteLine("Does Person 1 make more money than Person 2: ");
            bool TrueOrFalse = salaryPerson1 > salaryPerson2;
            Console.WriteLine(TrueOrFalse);
            Console.ReadLine();
        }
    }
}
