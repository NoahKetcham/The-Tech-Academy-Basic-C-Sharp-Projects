using System;

// Main class of the application
class Program
{
    static void Main()
    {
        // Instantiate the Operations class
        Operations operations = new Operations();

        // Prompt the user for input
        Console.Write("Enter a number to perform operations on: ");
        int input = Convert.ToInt32(Console.ReadLine()); // Converts the input string to an integer

        // Call the Double method and display the result
        int resultDouble = operations.Double(input);
        Console.WriteLine($"Double of {input} is {resultDouble}");

        // Call the Square method and display the result
        int resultSquare = operations.Square(input);
        Console.WriteLine($"Square of {input} is {resultSquare}");

        // Call the AddTen method and display the result
        int resultAddTen = operations.AddTen(input);
        Console.WriteLine($"{input} plus 10 is {resultAddTen}");

        // Wait for the user to press a key before closing
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
