using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperatorsAssignemnt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            // GET PERSON 1 INFORMATION
            Console.WriteLine("Person 1");
            Console.Write("Enter your hourly rate: ");
            decimal hourlyRate1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Hours worked per week: ");
            int hoursWeek1 = Convert.ToInt32(Console.ReadLine());

            // GET PERSON 2 INFORMATION
            Console.WriteLine("Person 2");
            Console.Write("Enter your hourly rate: ");
            decimal hourlyRate2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Hours worked per week: ");
            int hoursWeek2 = Convert.ToInt32(Console.ReadLine());

            // Calculate salary of person 1 using the * operand 
            decimal annualSalary1 = hourlyRate1 * hoursWeek1 * 52;
            Console.WriteLine("Annual Salary of person 1 is: ");
            Console.WriteLine(annualSalary1);
            Console.ReadLine();

            // Calculate salary of person 2 using the * operand 
            decimal annualSalary2 = hourlyRate2 * hoursWeek2 * 52;
            Console.WriteLine("Annual Salary of person 1 is: ");
            Console.WriteLine(annualSalary2);
            Console.ReadLine();

            // Determine who makes mare with a boolean operand 
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool makesMore = annualSalary1 > annualSalary2;
            Console.WriteLine(makesMore);
            Console.ReadLine();
        }
    }
}
