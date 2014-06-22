// 1. Write a program that reads an integer number and calculates and prints its square root. 
//      If the number is invalid or negative, print "Invalid number". 
//      In all cases finally print "Good bye". Use try-catch-finally.

using System;

class TrySquareRoot
{
    static double FastSqrt(uint number)
    {
        if (0 == number) 
        { 
            return 0; 
        }

        double a = (number / 2) + 1; 
        double b = (a + (number / a)) / 2;
        while (b < a)
        {
            a = b;
            b = (a + (number / a)) / 2;
        }

        return a;
    }

    static void CalculateSqrt()
    {
        try
        {
            Console.Write("Enter a number: ");
            string strNum = Console.ReadLine();
            uint number = uint.Parse(strNum);
            
            double squareRoot = FastSqrt(number);
            Console.WriteLine("The square root of {0} is {1}.", number, squareRoot);
        }
        catch (FormatException)
        {
            Console.Error.WriteLine("Invalid number!");
        }
        catch (OverflowException)
        {
            Console.Error.WriteLine("Invalid number!");
        }
        finally
        {
            Console.Error.WriteLine("Good bye!");
        }
    }

    static void Main()
    {
        CalculateSqrt();
    }
}
