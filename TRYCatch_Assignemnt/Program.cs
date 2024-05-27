using System;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter your age: ");
                string input = Console.ReadLine();
                int age = int.Parse(input);

                if (age <= 0)
                {
                    Console.WriteLine("Error: Age must be a positive number greater than zero.");
                    Console.ReadLine();
                }
                else
                {
                    int birthYear = DateTime.Now.Year - age;
                    Console.WriteLine($"You were born in the year {birthYear}.");
                    Console.ReadLine();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid number for your age.");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                Console.ReadLine();
            }
        }
    }
}
