using System;


class Program
{
    static void Main(string[] args)
    {
        // Create an instance of hte MathOperations class
        MathOperations operations = new MathOperations();

        // Promt the user for the first number
        Console.WriteLine("Enter the first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        // Prompt the user for the optional second number
        Console.WriteLine("Enter the second number, or leave blank: ");
        string input = Console.ReadLine();
        int secondNumber = 10;

        // If the user enters something, parse it to integer
        if (!string.IsNullOrEmpty(input))
        {
            secondNumber = Convert.ToInt32(input);
        }

        // Call the AddNumbers method and store the result
        int result = operations.AddNumbers(firstNumber, secondNumber);

        // Print the result to the console
        Console.WriteLine($"Result: {result}");

        Console.ReadLine();
    }
}

