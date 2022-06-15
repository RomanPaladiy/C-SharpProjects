using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Methods
    {
        public int Multiplication(int userInput)
        {
            // Giving the instructions of the method and what to do when it's called.
            int totalNum = userInput * 23;
            Console.WriteLine("The product of " + userInput + " multiplied by 23 is: " + totalNum);
            return totalNum;
        }
       
        public int Addition(int userInput2)
        {
            // Giving the instructions for the Addition method when it's called.
            int totalsum = userInput2 + 18;
            Console.WriteLine("The sum of " + userInput2 + "and 18 is: " + totalsum);
            return totalsum;
        }
   
        public int Division(int userInput3)
        {
            // Giving the instructions for the Division method when it's called.
            int totalquotient = userInput3 / 2;
            Console.WriteLine("The quotient of " + userInput3 + "divided by 2 is: " + totalquotient);
            return totalquotient;
        }
    }
  
}
