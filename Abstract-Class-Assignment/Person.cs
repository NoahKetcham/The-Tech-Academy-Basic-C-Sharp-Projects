using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    public abstract class Person
    {
        // Properties to hold the first and last name.
        public string firstName { get; set; }
        public string lastName { get; set; }

        // Abstract method SayName, which must be implemented by any derived class.
        // This method is intended to print the person's full name to the console.
        public abstract void SayName();
    }
}
