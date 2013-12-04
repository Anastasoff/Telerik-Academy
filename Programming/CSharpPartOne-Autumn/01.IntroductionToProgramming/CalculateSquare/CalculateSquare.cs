// 8. Create a console application that calculates and prints the square of the number 12345.

using System;

class CalculateSquare
{
    static void Main()
    {
        double number = 12345;

        // It is faster to use * operator -> number * number
        double result = Math.Pow(number, 2); 
        Console.WriteLine(result);
    }
}
