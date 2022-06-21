using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Passing the classes to person.
            IQuittable person = new Employee();

            // Calling on the method to implement the string.
            person.Quit("Roman");
            Console.ReadLine();
        }
    }
}
