using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Submission_Assignment
{
    public class Employee
    {
        // Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the == operator
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (ReferenceEquals(emp1, null))
            {
                return ReferenceEquals(emp2, null);
            }

            return emp1.Id == emp2.Id;
        }

        // Overload the != operator
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Use the overloaded == operator 
            return !(emp1 == emp2);
        }

        // Override the Equals method to use operator overloading
        public override bool Equals(object obj)
        {
            var employee = obj as Employee;
            if (employee == null) return false;
            return this == employee;
        }

        // Override GetHashCode method
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}