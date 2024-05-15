using System;

namespace DayOfWeekEnumApp
{
    // Define an enum for the days of the week
    enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the current day of the week
            Console.WriteLine("Please enter the current day of the week (0 - 6):");

            try
            {
                // Read the user's input and convert it to a string
                string userInput = Console.ReadLine();

                // Attempt to parse the user input to a DaysOfWeek enum value
                DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);

                // Output the parsed enum value to the console
                Console.WriteLine($"{currentDay}");
                Console.ReadLine();
            }
            catch (Exception)
            {
                // If parsing fails, catch the exception and print an error message
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
            
        }
    }
}
