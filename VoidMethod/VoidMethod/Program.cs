using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompting an user input for the method.
            Console.WriteLine("Please input an integer.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Instantiating the class.
            Method mathObj = new Method();

            // Prompting another user input to print to the console.
            Console.WriteLine("Please input another integer.");
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            mathObj.mathMethod(3, 4);
            mathObj.mathMethod(userInput, userInput2) ;

            Console.ReadLine();
        }
    }
}
