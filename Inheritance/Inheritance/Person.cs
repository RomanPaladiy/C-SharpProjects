using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Person // This is the base class (Parent Class)
    {
        // Properties with the data type string.
        public string firstName { get; set; }
        public string lastName { get; set; }
        public void SayName()
        {
        Console.WriteLine("Name: " + firstName + " " + lastName);
        
        }

    }
}
