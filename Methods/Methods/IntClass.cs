using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class IntClass
    {
        // Passing parameters to the class and making one optional.
        public int Addition(int numberOne , int numberTwo = 1)
        {
            // Creating the function of the method.
            int totalSum = numberOne + numberTwo;
            return totalSum;
        }

    }
}
