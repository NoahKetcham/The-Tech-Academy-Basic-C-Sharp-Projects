using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the MathOperations class
        MathOperations operations = new MathOperations();

        // Prompt the user for the first number
        Console.WriteLine("Enter the first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        // Prompt the user for the optional second number
        Console.WriteLine("Enter the second number, or leave blank: ");
        string input = Console.ReadLine();

        int result;

        if (string.IsNullOrEmpty(input))
        {
            result = operations.AddNumbers(firstNumber);
        }
        else
        {
            int secondNumber = Convert.ToInt32(input);
            result = operations.AddNumbers(firstNumber, secondNumber);
        }

        // Print the result to the console
        Console.WriteLine($"Result: {result}");

        Console.ReadLine();
    }
}
