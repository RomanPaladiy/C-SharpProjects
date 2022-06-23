using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using DateTime Now to get the content and using the "G" which is a format of time.
            DateTime now = DateTime.Now;
            string strDate = now.ToString("G");
            Console.WriteLine(strDate);

            // Prompting the user for input.
            Console.WriteLine("Please input a number.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Writing to the console to add hours based on the int the user gave above.
            Console.WriteLine(now.AddHours(userInput));
            Console.ReadLine();
        }
    }
}
