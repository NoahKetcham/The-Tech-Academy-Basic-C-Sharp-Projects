using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create first employee object
            Employee emp1 = new Employee { Id = 1, FirstName = "Billy", LastName = "Joe" };

            // Create second employee object
            Employee emp2 = new Employee { Id = 2, FirstName = "Dilly", LastName = "Boe" };

            // Compare two employee objects
            if (emp1 == emp2)
            {
                Console.WriteLine("Both employees are the same.");
            }
            else
            {
                Console.WriteLine("Employees are different.");
            }
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}