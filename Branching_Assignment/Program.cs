using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below.");

            // Package weight Prompt
            Console.Write("Please enter the package weight: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            // Checking weight limit
            if (weight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express.  Have a good day.");
                Console.ReadLine();
                return; //Exits program
            }

            // Package width prompt
            Console.Write("Please enter the package width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            //Promtp for package height
            Console.Write("Please enter the package height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            //Promtp for package length
            Console.Write("Please enter the package length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            // calculate dimensions
            double totalDimensions = width + height + length;

            // Check size limits
            if (totalDimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            // Calculate shipping quote
            double quote = (width * height * length * weight) / 100;

            //Display the quote as a currency
            Console.WriteLine($"Your estimated total for shipping this package is : ${quote:F2}");
            Console.WriteLine("Thank you!");

            Console.ReadLine();
        }
    }
}
