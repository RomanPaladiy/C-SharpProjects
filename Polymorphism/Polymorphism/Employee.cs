using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // Inheriting from interface.
    public class Employee : IQuittable
    {

        // Giving the method an action.
        public void Quit(string name)
        {
            Console.WriteLine("Time to Quit, " + name);
        }
        public int Id { get; set; }
    }
}
