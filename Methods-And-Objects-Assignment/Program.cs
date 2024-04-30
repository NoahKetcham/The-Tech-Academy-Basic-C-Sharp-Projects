using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_And_Objects_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of Employee
            Employee employee = new Employee
            {
                FirstName = "Sample",  // Setting first name
                LastName = "Student",  // Setting last name
                Id = 1                 // Setting employee ID
            };

            // Calling SayName method 
            employee.SayName();

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
