using System;

// 6. Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN
class SumOfSeries
{
    static void Main()
    {
        Console.Write("Enter integer number N: ");
        int intN = int.Parse(Console.ReadLine());

        Console.Write("Enter integer number X: ");
        int intX = int.Parse(Console.ReadLine());

        double factorial = 1;
        double sqr = intX;
        double sum = 1;

        for (int i = 1; i <= intN; i++)
        {
            factorial = 1;
            sqr = intX;

            for (int y = 1; y <= i; y++)
            {
                factorial *= y;
                sqr *= intX;
            }

            sum += factorial / sqr;
        }

        Console.WriteLine("Sum = {0}", sum);
    }
}
