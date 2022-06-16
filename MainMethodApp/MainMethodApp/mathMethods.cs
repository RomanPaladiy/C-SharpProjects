using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodApp
{
    class mathMethods
    {
        public int Addition(int input)
        {
            int totalSum = input + 5;
            return totalSum;
        }

        public decimal Addition(decimal input)
        {
            int totalDiff = (int)(input - 10);
            return totalDiff;
        }

        public string Addition(string input)
        {
            ;
            string product = input + 10;
            return product;
        }


    }
}
