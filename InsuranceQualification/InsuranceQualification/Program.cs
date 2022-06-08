using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceQualification
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompting user for their Age.
            Console.WriteLine("Insurance Qualification.");
            Console.WriteLine("What is your age?");
            int yearsOld = Convert.ToInt32(Console.ReadLine());

            // Asking if user has ever had a DUI.
            Console.WriteLine("Have you ever had a DUI? Please answer true or false.");
            bool DuiInfo = Convert.ToBoolean(Console.ReadLine());

            // Asking how many speeding tickets user has had.
            Console.WriteLine("How many speeding tickets do you have?");
            int numOfTickets = Convert.ToInt32(Console.ReadLine());

            // Creating the logic behind whether or not they qualify.
            bool approvedOrNot = (yearsOld > 15 && DuiInfo != true && numOfTickets <= 3);
            
            // Result for the user.
            Console.WriteLine("Qualified?");
            Console.WriteLine(approvedOrNot);
            Console.ReadLine();

        }
    }
}
