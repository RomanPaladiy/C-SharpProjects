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
            return totalNum;
        }
       
        public int Addition(int userInput2)
        {
            // Giving the instructions for the Addition method when it's called.
            int totalsum = userInput2 + 18;
            return totalsum;
        }
   
        public int Division(int userInput3)
        {
            // Giving the instructions for the Division method when it's called.
            int totalquotient = userInput3 / 2;
            return totalquotient;
        }
    }
  
}
