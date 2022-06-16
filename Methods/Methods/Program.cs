using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompting the user for one number to do the math equation with.
            Console.WriteLine("Please input a number.");
            int input = Convert.ToInt32(Console.ReadLine());
            IntClass mathObject = new IntClass();
            
            // Implementing a try and catch block incase a number isn't entered.
            try
            {
                Console.WriteLine("Please input a second number if you want.");
                int input2 = Convert.ToInt32(Console.ReadLine());
                int result = mathObject.Addition(input, input2);
                Console.WriteLine(result);

            }
            catch
            // If no number is entered for the second time it throws the default value set.
            {
                int result = mathObject.Addition(input);
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
