using System;

namespace DailyReportAssignemnt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduction
            Console.WriteLine("The Tech Academy."); //prints text to console
            Console.WriteLine("Student Daily Report.");

            // Wuestions
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine(); // Console reads input to store studentName data as a string

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();

            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());// Console reads input to store pageNumber data as an int

            Console.WriteLine("Do you need help with anything? Please answer “true” or “false.”");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());// Console reads input to store needHelp data as a boolean with "True or False"

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            double studyHours = Convert.ToDouble(Console.ReadLine()); // Console reads input to store studyHours data as a double

            //End
            Console.WriteLine("Thank you for your answers.  An instructor will respond to this shortly.  Have a great day!");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();  //Keeps console open for another input after the studyHours input 
        }
    }
}
