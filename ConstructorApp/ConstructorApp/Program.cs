using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a variable using the keyword var/
            var lastName = "Paladiy";

            // Creating a const variable.
            const string firstName = "Roman";
            Console.WriteLine("Hello, My name is {0} {1}.", firstName, lastName);
            Console.ReadLine();

            RandomClass a = new RandomClass(), b = new RandomClass(500, "def"), c = new RandomClass(324), d = new RandomClass("abc");

            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
