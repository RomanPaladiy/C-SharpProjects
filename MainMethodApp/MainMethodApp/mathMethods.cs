using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodApp
{
    class mathMethods
    {
        // each method is taking in different inputs but returning the same int type.
        public int Addition(int input)
        {
            int totalSum = input + 5;
            return totalSum;
        }

        // Converting to decimal 
        public int Addition(decimal input)
        {
            int totalDiff = (int)(input - 10);
            return totalDiff;
        }

        // Converting the result to have an int type.
        public int Addition(string input)
        {
            int product = Convert.ToInt32(input) + 10;
            return product;
        }
    }
}
