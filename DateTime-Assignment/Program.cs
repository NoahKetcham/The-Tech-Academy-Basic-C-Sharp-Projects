using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Print the current date and time to the console
            Console.WriteLine("Current date and time: " + DateTime.Now);

            // Step 2: Ask the user for a number
            Console.WriteLine("Enter a number of hours: ");
            string input = Console.ReadLine();
            int hours;
            while (!int.TryParse(input, out hours))
            {
                Console.Write("Invalid input. Please enter a valid number of hours: ");
                input = Console.ReadLine();
            }

            // Step 3: Calculate and print the exact time it will be in X hours
            DateTime futureTime = DateTime.Now.AddHours(hours);
            Console.WriteLine("In {0} hours, it will be: {1}", hours, futureTime);
            Console.ReadLine();
        }
    }
}
