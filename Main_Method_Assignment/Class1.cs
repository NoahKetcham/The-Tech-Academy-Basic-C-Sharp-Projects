using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Instantiate a class and making it public 
public class MathOperations
{
    // method to perform multiplication on the users number
    public int PerformOperation(int number)
    {
        return number * 10;
    }

    // method to perform addition on the users number
    public int PerformOperation(decimal number)
    {
        return (int)(number + 5);
    }

    // Method to convert the users string to an integer, then multiply it
    public int PerformOperation(string text)
    {
        int number = int.Parse(text);
        return number * 5;
    }
}
