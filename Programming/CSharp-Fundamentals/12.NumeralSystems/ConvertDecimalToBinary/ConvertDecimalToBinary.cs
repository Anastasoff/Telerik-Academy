// 1. Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;

class ConvertDecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        int number = int.Parse(Console.ReadLine());

        List<int> binaryList = new List<int>();
        while (number > 0)
        {
            binaryList.Add(number % 2);
            number = number / 2;
        }

        for (int i = binaryList.Count - 1; i >= 0; i--)
        {
            Console.Write("{0} ", binaryList[i]);
        }

        Console.WriteLine();
    }
}
