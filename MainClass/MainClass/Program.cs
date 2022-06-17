using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompting user to input an integer to be divided by 2.
            Console.WriteLine("Please input an integer to be divided by 2.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            // Instantiating the class. 
            Equation mathObj = new Equation();

            mathObj.Division(userNum);

            Console.ReadLine();
        }
    }
}
