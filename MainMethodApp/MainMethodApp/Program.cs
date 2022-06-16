using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompting the user to input an integer.
            Console.WriteLine("Please provide an integer.");
            int input = Convert.ToInt32(Console.ReadLine());

            // Instantiating the class and passing it to mathObject.
            mathMethods mathObject = new mathMethods();
            
            // Calling the Addition method from the class mathMethods
            int firstResult = mathObject.Addition(input);
            Console.WriteLine(firstResult);

            // Prompting user for a decimal to then do a math operation with decimals.
            Console.WriteLine("Please provide a decimal number.");
            decimal input2 = Convert.ToDecimal(Console.ReadLine());
            int secondResult = mathObject.Addition(input2);
            Console.WriteLine(secondResult);

            //Prompting user for a string to then do a math operation with it.
            Console.WriteLine("Please provide a string.");
            string input3 = Console.ReadLine();
            int thirdResult = mathObject.Addition(input3);
            Console.WriteLine(thirdResult);
        }
    }
}           
