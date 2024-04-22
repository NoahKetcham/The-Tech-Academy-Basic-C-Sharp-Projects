using System;
using System.Collections.Generic;

namespace ConsoleAppAssignment6Parts
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART ONE ARRAY AND ITERATION------------------------------------------------------------------------------------------------------------------------------
            // one-dimensional array of strings
            string[] strings = { "Hello", "World", "This", "is", "an", "Array" };

            // Ask the user to input some text
            Console.WriteLine("Please Enter some text here: ");
            string userInput = Console.ReadLine();

            // iterate through each string in the array and add the users text 
            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] += userInput; //Append to each element
            }

            // Create a second loop which prints off each string in the array one at a time
            Console.WriteLine("Appended array elements: ");
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            // --------------------------------------------------------------------------------------------------------------------------------------------------------


            // PART THREE 

            //first loop with "<" operator
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine($"Loop 1: the current value of k is {k}");
            }

            // second loop with <= operator
            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine($"Loop 2: Current value of j is {j}");
            }

            //---------------------------------------------------------------------------------------------------------------------------------------------------------

            // PART TWO Infinite loop------------------------------------------------------------------------------------------------------------------------------------------
            while (true)
            {
                Console.WriteLine("Infinite Loop type 'stop' to stop");
                string stopInput = Console.ReadLine();
                if (stopInput == "stop")  // input to stop the infinite loop
                    break;
            }
            // --------------------------------------------------------------------------------------------------------------------------------------------------------

            // PART FOUR ----------------------------------------------------------------------------------------------------------------------------------------------

            //Creating a list
            var items = new List<string> {"blue", "yellow", "red", "green", "orange", "white" };

            // ask user to input text for a color to search
            Console.WriteLine("Enter a color to search for in the list: ");
            string colorInput = Console.ReadLine();

            // using a boolean to determine if a match is found
            bool found = false;

            // loop through the list to find a match
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Contains(colorInput))
                {
                    Console.WriteLine($"Your color was found at index {i}.");
                    Console.ReadLine();
                    found = true;
                    break; // stops the loop when a match is found
                }
            }

            // Check if no match was found
            if (!found)
            {
                Console.WriteLine("Your Color is not on the list");
                Console.ReadLine();
            }

            //---------------------------------------------------------------------------------------------------------------------------------

            // PART FIVE-----------------------------------------------------------------------------------------------------------------------

            //Creating the list
            var moneyList = new List<string> { "one", "two", "five", "five", "ten", "twenty", "fifty", "hundred", "hundred" };

            // ask user to input text for a color to search
            Console.WriteLine("Enter a cash denomination to search for in the list: ");
            string moneyInput = Console.ReadLine();

            // using a boolean to determine if a match is found
            bool foundMatch = false;

            // loop through the list to find a match
            for (int i = 0; i < moneyList.Count; i++)
            {
                if (moneyList[i] == moneyInput)
                {
                    foundMatch = true;  // Set flag to true if a match is found
                    Console.WriteLine($"'{moneyInput}' found at index {i}");
                    Console.ReadLine();
                }
            }

            // Check if the input text was not found
            if (!found)
            {
                Console.WriteLine($"'{moneyInput}' is not in the list.");
                Console.ReadLine();
            }

            //--------------------------------------------------------------------------------------------------------------------------------------------------

            //PART SIX------------------------------------------------------------------------------------------------------------------------------------------

            // Create a list of strings with duplicates
            List<string> stringsEach = new List<string> { "A", "B", "C", "D", "C" };

            // HashSet keeps track of seen strings
            HashSet<string> seenStrings = new HashSet<string>();

            //Loop through each string in the list
            foreach (var item in stringsEach)
            {
                // Check if the item has been seen
                if (seenStrings.Contains(item))
                {
                    Console.WriteLine($"{item} - this item is a duplicate");
                }
                else
                {
                    Console.WriteLine($"{item} - this item is unique");
                    seenStrings.Add(item); // Mark this item as seen
                }

                Console.ReadLine();
            }

            //--------------------------------------------------------------------------------------------------------------------------------------------------
            Console.ReadLine();
        }
    }
}
