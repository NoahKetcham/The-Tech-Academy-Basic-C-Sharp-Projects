using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    public class Employee : Person
    {
        // Overrides the SayName method from the Person class.
        // This implementation prints the full name of the employee to the console.
        public override void SayName()
        {
            Console.WriteLine($"Name: {firstName} {lastName}");
        }
    }
}
