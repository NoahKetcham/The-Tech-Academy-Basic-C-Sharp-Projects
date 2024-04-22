using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a one-dimensional array of strings
            string[] stringArray = { "Hello", "World", "Test", "Array" };
            // Ask the user to select an index of the Array
            Console.WriteLine("Select an index from the string array (0-3):");
            // Read the user input and convert it to integer
            int stringIndex = Convert.ToInt32(Console.ReadLine());
            // Check if the index is within the array
            if (stringIndex >= 0 && stringIndex < stringArray.Length)
            {
                // Display the string at the selected index
                Console.WriteLine("Selected string: " + stringArray[stringIndex]);
                Console.ReadLine();
            }
            else
            {
                // Display an error message if the index is out of bounds
                Console.WriteLine("Index out of range!");
                Console.ReadLine();
            }

            // Create a one-dimensional array of integers
            int[] intArray = { 1, 2, 3, 4, 5 };
            // ask the user to select an index of the integer array
            Console.WriteLine("Select an index from the integer array (0-4):");
            // Read the user input and convert it to integer
            int intIndex = Convert.ToInt32(Console.ReadLine());
            // Check if the selected index is within the bounds of the array
            if (intIndex >= 0 && intIndex < intArray.Length)
            {
                // Display the integer at the selected index
                Console.WriteLine("Selected integer: " + intArray[intIndex]);
            }
            else
            {
                // Display an error message if the index is out of bounds
                Console.WriteLine("Index out of range!");
            }

            // Create a list of strings
            var stringList = new System.Collections.Generic.List<string> { "apple", "orange", "banana", "grape" };
            // Prompt the user to select an index of the list
            Console.WriteLine("Select an index from the list of strings (0-3):");
            // Read the user input and convert it to integer
            int listIndex = Convert.ToInt32(Console.ReadLine());
            // Check if the selected index is within the bounds of the list
            if (listIndex >= 0 && listIndex < stringList.Count)
            {
                // Display the content at the selected index of the list
                Console.WriteLine("Selected string from list: " + stringList[listIndex]);
            }
            else
            {
                // Display an error message if the index is out of bounds
                Console.WriteLine("Index out of range!");
            }

            // Keep the console open
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
