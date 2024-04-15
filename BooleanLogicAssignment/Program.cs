using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insuarance Application");

            // Age question
            Console.Write("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            
            //Dui Question
            Console.Write("Have you ever had a DUI? (true/false)");
            string duiResponse = Console.ReadLine().Trim().ToLower();
            bool hasDUI = duiResponse == "true";

            //Sppeding ticket question
            Console.Write("How many speeding tickets do you have? ");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            //Qualification

            bool isQualified = age > 15 && !hasDUI && speedingTickets <= 3;

            Console.WriteLine($"Application Approved: {isQualified}");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
