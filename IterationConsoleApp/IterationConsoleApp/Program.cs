using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //// Part 1 (string + userInput)
        //string[] names = { "Name: ", "Name: ", "Name: ", "Name: " };
        //Console.WriteLine("Input a name please.");
        //string userInput = Console.ReadLine();
        //for (int n = 0; n < names.Length; n++)
        //{
        //    names[n] = (names[n] + userInput);
        //    Console.WriteLine(names[n]);
        //}


        //// infinite loop and fix part 2
        //int count = 0;
        //while (true)
        //{
        //    Console.WriteLine("hello", count);
        //    if (count < 3)
        //    {
        //        break;
        //    }
        //}

        //// Part 3 (loop with <=)
        //for (int i = 0; i <= 5; i++)
        //{
        //    Console.WriteLine("Hi");
        //}
        //// Part 3 (loop with <)
        //for (int i = 0; i < 3; i++)
        //{
        //    Console.WriteLine("There");
        //}

        //// Part 4 
        //List<string> randomText = new List<string>() { "This is", "random", "hello" };
        //Console.WriteLine("Input text to guess the random strings in the array.");
        //string userInput2 = Console.ReadLine();
        //bool found = false;
        //for (int i = 0; i < randomText.Count; i++)
        //{
        //    if (userInput2 == randomText[i])
        //    {
        //        Console.WriteLine("You found it at index {0}! ", i);
        //        found = true;
        //        break;
        //    }
        //}
        //if (!found)
        //{
        //    Console.WriteLine("Nope! Thats not in the index list.");
        //}

        //// Part 5 
        //List<string> uniqueText = new List<string>() { "Different", "Same", "Same"};
        //Console.WriteLine("Guess some random text in the list of strings.");
        //string userGuess = Console.ReadLine();
        //bool guessed = false;
        //for (int j = 0; j < uniqueText.Count; j++)
        //{
        //    if (userGuess == uniqueText[j])
        //    {
        //        Console.WriteLine("You got it at index {0}!", j);
        //        guessed = true;
        //    }
        //}
        //if (!guessed)
        //{
        //    Console.WriteLine("Nope! That's not on the list of strings!");
        //}

        // Part 6 
        List<string> stringList1 = new List<string>() { "One", "Two", "Three", "Four", "Three" };
        List<string> stringList2 = new List<string>();

        foreach (string input in stringList1)
        {
            if (stringList2.Contains(input))
            {
                Console.WriteLine("{0} has already been seen in the list.", input);

            }
            else
            {
                stringList2.Add(input);
                Console.WriteLine("{0} has not been seen in the list.", input);
            }  

        }
        Console.ReadLine();
    }
}
