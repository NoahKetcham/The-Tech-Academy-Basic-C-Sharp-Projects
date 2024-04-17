using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assingment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Concatenating three strings
            string part1 = "Hello";
            string part2 = "Tech";
            string part3 = "Academy";
            string concatenateThree = part1 + " " + part2 + " " + part3;
            Console.WriteLine("This string was concatenated from three different strings:\n" + concatenateThree);
            Console.ReadLine();

            // Convert to Upper string
            string lowerString = "this was lowercase";
            string upperString = lowerString.ToUpper();
            Console.WriteLine("This string was originally all lowercase:\n" + upperString);
            Console.ReadLine();

            // Creates a Stringbuilder
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("This is the first sentence of the paragraph.");
            sb.AppendLine("This is the second sentence of the paragraph.");
            sb.AppendLine("This is the third sentence of the paragraph.");
            sb.AppendLine("This is the fourth sentence of the paragraph.");

            // Display the paragraph
            Console.WriteLine("Built Paragraph:\n" + sb.ToString());
            Console.ReadLine();
        }
    }
}
