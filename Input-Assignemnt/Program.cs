using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input_Assignemnt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a number
            Console.WriteLine("Please enter a number: ");
            string userInput = Console.ReadLine();

            // Specify the file path
            string filePath = @"C:\Users\Noah\Documents\log.txt";

            // Log the number to a text file
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(userInput);
            }

            // Read the text file and print it back to the user
            string fileContent = File.ReadAllText(filePath);
            Console.WriteLine("The content of the text file is: ");
            Console.WriteLine(fileContent);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
