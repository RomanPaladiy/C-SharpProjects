using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            // starting the try and catch block (trying the program)
            try
            {
                List<int> integerList = new List<int>() { 25, 64, 65, 42, 1, 6 };
                Console.WriteLine("Input a number that will divide the index integers.");
                int chosenNum = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < integerList.Count; i++)
                {
                    Console.WriteLine("The answer is: " + integerList[i] / chosenNum);
                }
            // This is catching the errors and displaying custom/default message. 
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.ReadLine();
    }
        }
}
