using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic switch statement
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool guessedNum = number == 146;

            // Do while statement allowing for a loop to continue until correct num is found.
            do
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("You guessed 1. Go Again!");
                        Console.WriteLine("Choose a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 89:
                        Console.WriteLine("You guessed 89. Go Again!");
                        Console.WriteLine("Choose a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 86:
                        Console.WriteLine("You guessed 86. Go Again!");
                        Console.WriteLine("Choose a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 146:
                        Console.WriteLine("You guessed 146. That is correct!");
                        guessedNum = true;
                        break;
                    default:
                        Console.WriteLine(" Nope, you are wrong!");
                        Console.WriteLine("Choose a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
                while (!guessedNum);
                Console.Read();
        }

    }
}
