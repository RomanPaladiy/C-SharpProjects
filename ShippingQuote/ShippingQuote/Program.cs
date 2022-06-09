using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduction to the program.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompting package weight.
            Console.WriteLine("Please enter the package weight:");
            int packWeight = Convert.ToInt32(Console.ReadLine());
            if (packWeight > 50)
            {
                Console.WriteLine("Package is too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            // Prompting package width.
            Console.WriteLine("Please enter the package width:");
            int packWidth = Convert.ToInt32(Console.ReadLine());
            if (packWidth > 50)
            {
                Console.WriteLine("Package is too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(1);
            }

            // Prompting package height.
            Console.WriteLine("Please enter the package height:");
            int packHeight = Convert.ToInt32(Console.ReadLine());
            if (packHeight > 50)
            {
                Console.WriteLine("Package is too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(2);
            }

            // Prompting package length.
            Console.WriteLine("Please enter the package length:");
            int packLength = Convert.ToInt32(Console.ReadLine());
            if (packLength > 50)
            {
                Console.WriteLine("Package is too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(3);
            }

            // Calculating the inputs to generate a quote.
            Console.WriteLine("Your estimated total for shipping this package is: $");
            int totalNum = (packHeight * packWidth * packLength);
            Console.WriteLine(totalNum * packWeight / 100);
            Console.ReadLine();
        }
    }
}
