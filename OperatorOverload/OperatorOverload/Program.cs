using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Instantiating both objects.
            Employee person = new Employee();
            Employee person2 = new Employee();

            // Passing in the values for the Id.
            person.Id = 542;
            person2.Id = 541;

            Console.WriteLine(person == person2);
            Console.ReadLine();

        }
    }
}
