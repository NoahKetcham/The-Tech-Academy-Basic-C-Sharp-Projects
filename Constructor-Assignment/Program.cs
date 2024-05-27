using System;

namespace ConsoleApp
{
    class Program
    {
        // Define a const variable
        const string greeting = "Hello, World!";

        static void Main(string[] args)
        {
            // Create a variable using the keyword “var”
            var message = "This is a variable using var.";

            Console.WriteLine(greeting);
            Console.WriteLine(message);

            // Create an instance of the class to demonstrate constructor chaining
            Person person = new Person("John", "Doe");
            Console.WriteLine($"Full Name: {person.FullName}");
            Console.ReadLine();
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }

        // Constructor chaining
        public Person(string firstName) : this(firstName, "Unknown")
        {
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            FullName = $"{FirstName} {LastName}";
            Console.WriteLine();
        }
    }
}
