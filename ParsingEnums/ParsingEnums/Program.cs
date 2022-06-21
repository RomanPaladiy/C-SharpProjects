using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {

            // Creating a try/catch block incase user doesn't input an actual day of week.
            try
            {
                Console.WriteLine("Please enter the current day of the week.");
                string currentDay = Console.ReadLine();

                // Parsing through index to find if its a match. Then Prints.
                DaysOfWeek day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), currentDay);
                Console.WriteLine(day);
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
        }
    }
}
