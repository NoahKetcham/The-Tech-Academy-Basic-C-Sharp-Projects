using System;

class Program
{
    //static void Main()
    //{
    //    // Infinite loop to keep program running and allow easier use
    //    MathOperations operations = new MathOperations();
    //    while (true)
    //    {
    //        // prompt the user
    //        Console.WriteLine("Enter a value (integer, decimal, or text) or type 'exit' to close:");
    //        string input = Console.ReadLine();

    //        // quit the program if user types "exit"
    //        if (input.ToLower() == "exit")
    //        {
    //            break;
    //        }

    //        try
    //        {
    //            // determine which value has been inputted (int, dec, string) & call the appropriate function
    //            if (int.TryParse(input, out int intResult))
    //            {
    //                int result = operations.PerformOperation(intResult);
    //                Console.WriteLine("Result with integer: " + result);
    //            }
    //            else if (decimal.TryParse(input, out decimal decResult))
    //            {
    //                int result = operations.PerformOperation(decResult);
    //                Console.WriteLine("Result with decimal: " + result);
    //            }
    //            else
    //            {
    //                int result = operations.PerformOperation(input);
    //                Console.WriteLine("Number of characters in text: " + result);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine("Error: " + e.Message);
    //        }

    //        Console.WriteLine(); 
    //    }
    //}

    static void Main()
    {
        MathOperations operations = new MathOperations();
        int result = operations.PerformOperation(35);
        int result1 = operations.PerformOperation(3.5M);
        int result2 = operations.PerformOperation("3");

        Console.WriteLine("Result with integer: " + result);
        Console.WriteLine("Result with decimal: " + result1);
        Console.WriteLine("Result with string converted to integer: " + result2);
        Console.ReadLine();
    }
}
