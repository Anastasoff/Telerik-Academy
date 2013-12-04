// 3. Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

using System;

class MinAndMaxValueOfSecuence
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int num = int.Parse(Console.ReadLine());

        int var = 0;
        int maxValue = 0;
        int minValue = 0;

        Console.Write("Enter integer number: ");
        var = int.Parse(Console.ReadLine());
        minValue = maxValue = var;

        for (int i = 1; i < num; i++)
        {
            Console.Write("Enter integer number: ");
            var = int.Parse(Console.ReadLine());

            if (maxValue < var)
            {
                maxValue = var;
            }
            if (minValue > var)
            {
                minValue = var;
            }

        }

        Console.WriteLine("Min value is: {0}", minValue);
        Console.WriteLine("Max value is: {0}", maxValue);
    }
}