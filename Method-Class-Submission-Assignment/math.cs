using System;

public class MathOperation
{
    // Method that performs a mathematical operation on the first integer and displays the second integer
    public void PerformOperation(int firstNumber, int secondNumber)
    {
        // Example operation: multiply the first number by 2
        int result = firstNumber * 2;

        // Display the second number
        Console.WriteLine("The second number is: " + secondNumber);
        // Display the result of the operation for clarity
        Console.WriteLine("The result of doubling the first number is: " + result);
    }
}