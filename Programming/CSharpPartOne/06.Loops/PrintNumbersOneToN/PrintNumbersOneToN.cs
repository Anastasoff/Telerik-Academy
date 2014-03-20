using System;

// 1. Write a program that prints all the numbers from 1 to N.
class PrintNumbersOneToN
{
    static void Main()
    {
        Console.Write("Enter n = ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}
