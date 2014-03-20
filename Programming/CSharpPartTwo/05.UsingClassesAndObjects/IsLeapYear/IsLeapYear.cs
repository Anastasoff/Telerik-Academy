// 1. Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;

class IsLeapYear
{
    static void PrintResult(bool result)
    {
        if (result)
        {
            Console.WriteLine("It is a leap year.");
        }
        else
        {
            Console.WriteLine("It isn't a leap year.");
        }
    }

    static bool IsLeap(int year)
    {
        bool result = DateTime.IsLeapYear(year);
        return result;
    }

    static int Input()
    {
        Console.Write("Enter an year: ");
        int year = int.Parse(Console.ReadLine());
        return year;
    }

    static void Main()
    {
        PrintResult(IsLeap(Input()));
    }
}