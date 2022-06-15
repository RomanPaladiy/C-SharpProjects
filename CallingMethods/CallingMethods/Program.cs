using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompting user to provide an input in integer form.
            Console.WriteLine("Please input an integer.");
            int input = Convert.ToInt32(Console.ReadLine());

            // Instantiating the class and passing it to the mathObj
            Methods mathObj = new Methods();

            // Using the methods from the Methods Class and passing it the input from above code.
            int result1 = mathObj.Multiplication(input);
            Console.WriteLine("The product of the " + input + " multiplied by 23 is: " + result1);

            int result2 = mathObj.Division(input);
            Console.WriteLine("The quotient of " + input + " divided by 2 is: " + result2);

            int result3 = mathObj.Addition(input);
            Console.WriteLine("The sum of " + input + " and 18 is: " + result3);
            Console.ReadLine();
        }
    }
    
}
