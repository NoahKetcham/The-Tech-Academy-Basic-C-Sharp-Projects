using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of employees
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 2, FirstName = "John", LastName = "Doe" },
                new Employee { Id = 3, FirstName = "Jane", LastName = "Doe" },
                new Employee { Id = 4, FirstName = "Joe", LastName = "Johnson" },
                new Employee { Id = 5, FirstName = "Anna", LastName = "Taylor" },
                new Employee { Id = 6, FirstName = "James", LastName = "Brown" },
                new Employee { Id = 7, FirstName = "Emily", LastName = "Davis" },
                new Employee { Id = 8, FirstName = "Michael", LastName = "Miller" },
                new Employee { Id = 9, FirstName = "Sarah", LastName = "Wilson" },
                new Employee { Id = 10, FirstName = "David", LastName = "Anderson" }
            };

            // Using a foreach loop create a list of all employees with the first name "Joe"
            List<Employee> joesForeach = new List<Employee>();
            foreach (Employee emp in employees)
            {
                if (emp.FirstName == "Joe")
                {
                    joesForeach.Add(emp);
                }
            }

            // Using a lambda expression create a list of all employees with the first name "Joe"
            List<Employee> joesLambda = employees.Where(emp => emp.FirstName == "Joe").ToList();

            // Using a lambda expression make a list of all employees with an Id number > than 5
            List<Employee> idGreaterThanFive = employees.Where(emp => emp.Id > 5).ToList();

            // Display the results
            Console.WriteLine("Employees with the first name 'Joe' (foreach loop):");
            foreach (var emp in joesForeach)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}");
                Console.ReadLine();
            }

            Console.WriteLine("\nEmployees with the first name 'Joe' (lambda expression):");
            foreach (var emp in joesLambda)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}");
                Console.ReadLine();
            }

            Console.WriteLine("\nEmployees with Id greater than 5 (lambda expression):");
            foreach (var emp in idGreaterThanFive)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}");
                Console.ReadLine();
            }
        }
    }
}