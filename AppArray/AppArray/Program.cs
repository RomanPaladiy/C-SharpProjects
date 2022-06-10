using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an array/index.
            Console.WriteLine("Choose an Index of the array. 0-5");
            int numChosen = Convert.ToInt32(Console.ReadLine());
            int[] IntArray = new int[6];
            IntArray[0] = 10;
            IntArray[1] = 20;
            IntArray[2] = 30;
            IntArray[3] = 40;
            IntArray[4] = 50;
            IntArray[5] = 60;

            // Error for index number chosen that doens't exist.
            Console.WriteLine("That number does not exist in the index.");

            // Creating a list of strings.
            List<string> stringList = new List<string> {"string1", "string2", "string3", "string4"};

            // Creating an array of strings.
            string[] names = { "Justin", "Richard", "Christopher", "Anthony"};
            Console.WriteLine(names[0]);





            Console.ReadLine();
        }
    }
}
