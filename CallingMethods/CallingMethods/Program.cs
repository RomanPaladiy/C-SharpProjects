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
            mathObj.Multiplication(input);
            mathObj.Division(input);
            mathObj.Addition(input);

        }
    }
}
