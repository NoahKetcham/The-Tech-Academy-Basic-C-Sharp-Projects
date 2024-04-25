using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiating the class
        MathOperation mo = new MathOperation();

        // Calling the method with positional arguments
        mo.PerformOperation(5, 10);

        // Calling the method with named arguments
        mo.PerformOperation(firstNumber: 3, secondNumber: 6);
        Console.ReadLine();
    }
}