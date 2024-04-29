using System;
using Class_Submission_Assignment;

namespace Class_Submission_Assignment
{
    class Program
    {
        static void Main()
        {
            //instanciate divider class
            Divider myDivider = new Divider();

            // request user input
            Console.Write("Enter a number to divide by two: ");
            int inputNumber;
            if (int.TryParse(Console.ReadLine(), out inputNumber))
            {
                // Call the method 
                myDivider.DivideAndPrint(inputNumber);

                // Initialize the output parameter
                int outputResult;

                // Call the output parameter method and print
                myDivider.DivideAndReturn(inputNumber, out outputResult);
                Console.WriteLine("Output parameter result: " + outputResult);
            }
            else
            {
                // manage invalid inputs
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            // Using static class to display a message
            StaticClass.DisplayMessage("Message from the static class.");

            // Keep console open
            Console.ReadLine();
        }
    }
}
