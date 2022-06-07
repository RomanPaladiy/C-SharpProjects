using System;

namespace TechAcademyDR
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report.");

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Hello " + yourName);

            Console.WriteLine("What course are you on?");
            string courseInfo = Console.ReadLine();
            Console.WriteLine("Noted: " + courseInfo);

            Console.Write("What page number are you on?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your inputted page numeber " + pageNumber + " is saved.");

            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            bool answerInfo = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string experienceInfo = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedInfo = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");




















            Console.ReadLine();
        }
    }
}
