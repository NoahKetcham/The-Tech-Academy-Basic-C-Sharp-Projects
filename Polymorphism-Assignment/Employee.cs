using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment
{
    // The Employee class implements the IQuittable interface
    public class Employee : IQuittable
    {
        public string Name { get; set; }

        // Constructor to initialize the Employee with a name
        public Employee(string name)
        {
            Name = name;
        }

        // Implement the Quit method from the IQuittable interface
        public void Quit()
        {
            // Output a message stating the employee has quit
            Console.WriteLine($"{Name} has quit the job!");
        }
    }
}
