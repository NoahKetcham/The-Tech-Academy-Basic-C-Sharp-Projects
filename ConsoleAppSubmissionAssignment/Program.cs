using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;

            // The while loop will run as long as the numbewr is greater than 0
            while (number > 0)
            {
                Console.WriteLine($"Current number in while: {number}");
                number--; //subtract number by 1 each loop iteration
            }

            number = 5; // Reset number for next loop

            // This do-while loop will run at least once and continue until number is less than 10
            do
            {
                Console.WriteLine($"Current number in do-while: {number}");
                number++; //add one each loop iteration
            } while (number < 10);

            Console.WriteLine("Loop demonstrations complete. ");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
