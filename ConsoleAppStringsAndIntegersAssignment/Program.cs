using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStringsandIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) // using and infinite loop to keep the program running (Experiment)
            {
                ExecuteProgram();
                Console.WriteLine("Press any key to restart the program.....");
                Console.ReadKey();
                Console.Clear(); // Clears the console for the next run
            }
        }

        static void ExecuteProgram()
        {
            // list of integers
            int[] numbers = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Enter a number to divide each number in the list by: ");
            string input = Console.ReadLine();

            try
            {
                int divisor = int.Parse(input);

                // Loop through the list and dive the numbers in the list by the users provided number
                foreach (int number in numbers)
                {
                    int result = number / divisor;
                    Console.WriteLine($"{number} divided by {divisor} is {result}");
                    Console.ReadLine();
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid integer.");
                Console.ReadLine();
            }
            finally
            {
                // Finally will always excecute no matter the try/ catch result allowing the program to continue running
                Console.WriteLine("The program has completed the try/catch block and continues execution.  Press Enter to continue.");
                Console.ReadLine();
            }
        }
    }
}
