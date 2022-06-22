using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating the first Main list with Attributes.
            List<Employee> employeeList = new List<Employee>
            {
                new Employee{firstName = "Joe", lastName = "Johnson", Id = 1},
                new Employee{firstName = "Terry", lastName = "Johnson", Id = 2},
                new Employee{firstName = "Robin", lastName = "Johnson", Id = 3},
                new Employee{firstName = "Anthony", lastName = "Johnson", Id = 4},
                new Employee{firstName = "Benjamin", lastName = "Johnson", Id = 5},
                new Employee{firstName = "Karen", lastName = "Johnson", Id = 6},
                new Employee{firstName = "Joe", lastName = "Johnson", Id = 7},
                new Employee{firstName = "Lewis", lastName = "Johnson", Id = 8},
                new Employee{firstName = "Zachary", lastName = "Johnson", Id = 9},
                new Employee{firstName = "Eve", lastName = "Johnson", Id = 10},
            };

            // Creating second list to print out however many Joe's were in the first list.
            List<Employee> joeList = new List<Employee>();

            // Loop to add the actual content to the newly made list.
            foreach (Employee emp in employeeList)
            {
                if (emp.firstName == "Joe")
                {
                    joeList.Add(new Employee {firstName = emp.firstName, lastName = emp.lastName, Id = emp.Id});
                }
            }
            
            // Creating another loop to display the content using the index's to allow for more attributes to display.
            foreach (Employee emp in joeList)
            {
                Console.WriteLine("{0} {1} {2}", emp.firstName, emp.lastName, emp.Id);
            }

            // Lambda expressions to make a list of Joes.
            List<Employee> joesListTwo = employeeList.Where(x => x.firstName == "Joe").ToList();

            foreach (Employee emp in joesListTwo)
            {
                Console.WriteLine("{0} {1} {2}", emp.firstName, emp.lastName, emp.Id);
            }

            // Creating lambda expression to print all attributes with an Id over 5.
            List<Employee> numList = employeeList.Where(x => x.Id > 5).ToList();

            foreach (Employee emp in numList)
            {
                Console.WriteLine("{0} {1} {2}", emp.firstName, emp.lastName, emp.Id);
            }
            Console.ReadLine();
        }
    }
}
