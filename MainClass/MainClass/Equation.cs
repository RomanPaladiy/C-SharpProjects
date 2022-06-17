using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClass
{
    class Equation
    {
        // Creating a void method than outputs an integer and divides data passed to it.
        public void Division(int input)
        {
            int quotient = input / 2;
            Console.WriteLine(quotient);
        }

        //Creating method with 2 output parameters.
        static void Addition(int number, int number2)
        { 
            number = 10;
            number2 = 20;
        }


    }
}
