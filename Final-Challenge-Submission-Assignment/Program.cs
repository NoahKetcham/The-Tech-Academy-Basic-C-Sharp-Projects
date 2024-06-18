using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Challenge_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var student = new Student() { StudentName = "Noah" };

                ctx.Students.Add(student);
                ctx.SaveChanges();

                Console.WriteLine("Student saved successfully.");
            }

            ListStudents();
            Console.ReadLine();
        }

        private static void ListStudents()
        {
            using (var ctx = new SchoolContext())
            {
                var students = ctx.Students.ToList();

                Console.WriteLine("List of Students:");
                foreach (var student in students)
                {
                    Console.WriteLine($"- {student.StudentName}");
                }
            }
        }
    }
}
