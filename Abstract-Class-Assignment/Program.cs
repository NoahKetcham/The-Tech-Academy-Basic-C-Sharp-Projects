using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    class Program
    {
        // The Main method is the entry point of the application.
        // It is called by the runtime when the program starts.
        static void Main(string[] args)
        {
            // Create an instance of Employee with the first name "Sample" and the last name "Student".
            Employee employee = new Employee { firstName = "Sample", lastName = "Student" };

            // Call the SayName method on the employee instance to print the name to the console.
            employee.SayName();

            Console.ReadLine();
        }
    }
}
