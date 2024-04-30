using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    public abstract class Person
    {
        // hold the first and last name.
        public string firstName { get; set; }
        public string lastName { get; set; }

        // Abstract method SayName.
        // This method will print the person's full name to the console.
        public abstract void SayName();
    }
}
