using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    public class Employee
    {
        public int Id { get; set; }

        // Checking if objects are equal to one another.
        public static bool operator==(Employee personOne, Employee personTwo)
        {
            return personOne.Id == personTwo.Id;
        }
        // If they are not equal to one another, Return False.
         public static bool operator!=(Employee personOne, Employee personTwo)
        {
            return personOne.Id != personTwo.Id;
        }

    }
}
