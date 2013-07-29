// 1. Write a program that prints all the numbers from 1 to N.

using System;

class PrintNumberFrom1ToN
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int number = int.Parse(Console.ReadLine());
        int counter = 1;

        while (counter <= number)
        {
            Console.WriteLine(counter);
            counter++;
        }
    }
}
