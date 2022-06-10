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

            // Creating an array of strings.
            string[] names = { "Justin", "Richard", "Christopher", "Anthony" };
            Console.WriteLine("Choose an Index of the array. 0-3");
            int UserInput = Convert.ToInt32(Console.ReadLine());
            if (UserInput > names.Length - 1)
            {
                // Error for index number chosen that doens't exist.
                Console.WriteLine("That number does not exist in the index.");
            }
            else
            {
                Console.WriteLine(names[UserInput]);
            }

            
            // Creating an array/index.
            int[] IntArray = new int[6];
            IntArray[0] = 10;
            IntArray[1] = 20;
            IntArray[2] = 30;
            IntArray[3] = 40;
            IntArray[4] = 50;
            IntArray[5] = 60;
            Console.WriteLine("Choose an Index of the array. 0-5");
            int numChosen = Convert.ToInt32(Console.ReadLine());
            if (numChosen > IntArray.Length - 1)
            {
                // Error for index number chosen that doens't exist.
                Console.WriteLine("That number does not exist in the index.");
            }
            else
            {
            Console.WriteLine(IntArray[numChosen]);
            }


            // Creating a list of strings.
            List<string> stringList = new List<string> {"string1", "string2", "string3", "string4"};
            Console.WriteLine("Choose an Index of the list. 0-3");
            UserInput = Convert.ToInt32(Console.ReadLine());
            if (UserInput > stringList.Count -1)
            {
                // Error for index number chosen that doens't exist.
                Console.WriteLine("That number does not exist in the index.");
            }
            else
            {
                Console.WriteLine(stringList[UserInput]);
            }
            Console.ReadLine();
        }
    }
}
