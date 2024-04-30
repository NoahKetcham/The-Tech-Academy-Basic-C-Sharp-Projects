using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment
{
    class Program
    {
        static void Main()
        {
            // Create an instance of Employee but reference it as IQuittable
            IQuittable quittableEmployee = new Employee("John Doe");

            // Call the Quit method on the IQuittable object
            quittableEmployee.Quit();

            // Keep the console window open until a key is pressed
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
