using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {

            // Instantiating the class 
            Employee friend = new Employee();

            // Passing in values for the properties.
            friend.firstName = "Sample";
            friend.lastName = "Student";

            // Calling the Method from Person class.
            friend.SayName();
            Console.ReadLine();
        }
    }
}
