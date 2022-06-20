using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the class Employee which has the Person Attributes.
            Employee friend = new Employee();

            friend.firstName = "Sample";
            friend.lastName = "Student";
            friend.SayName();
            Console.ReadLine();
        }
    }
}
