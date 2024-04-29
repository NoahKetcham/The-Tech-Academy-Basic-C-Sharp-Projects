using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Submission_Assignment
{
    // creating a class to perform division
    public class Divider
    {
        // Method to divide and int by two and print the result
        public void DivideAndPrint(int number)
        {
            int result = number / 2;
            Console.WriteLine("result of division by 2: " + result);
        }

        //// Overloaded method performing division with the use of a double
        //public void DivideAndPrint(double number)
        //{
        //    double result = number / 2;
        //    Console.WriteLine("result of division by 2: " + result);
        //}

        // method to use an output parameter to achieve the same result
        public void DivideAndReturn(int number, out int result)
        {
            result = number / 2;
        }
    }
}
