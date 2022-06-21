using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating string type for Employee.(Passing in values)
            Employee<string> Obj = new Employee<string>();
            Obj.Things = new List<string>(){ "Bill", "Bob", "Jim"};

            // Instantiating int type for Employee.(Passing in values)
            Employee<int> Obj2 = new Employee<int>();
            Obj2.Things = new List<int>() { 3, 5, 6, 7 };

            // Creating a loop that prints out list of Things.
            foreach (int thing2 in Obj2.Things)
            {
                Console.WriteLine(thing2);
            }

            foreach (string thing in Obj.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
