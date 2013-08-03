// 7. Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

using System;
using System.Collections.Generic;

class ConvertAnyNumeralSystem
{
    static int ConvertToDecimal(string number, int baseS)
    {
        int decimalNumber = 0;
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] > '9')
            {
                decimalNumber += (number[i] - '7') * (int)Math.Pow(baseS, (number.Length - 1 - i));
            }
            else
            {
                decimalNumber += (number[i] - '0') * (int)Math.Pow(baseS, (number.Length - 1 - i));
            }
        }

        return decimalNumber;
    }

    static void ConvertFromDecimalToAny(int decimalNumber, int baseD)
    {
        List<string> anyNumberList = new List<string>();
        int element = 0;
        while (decimalNumber != 0)
        {
            element = decimalNumber % baseD;
            if (element < 10)
            {
                anyNumberList.Add(element.ToString());
            }
            else
            {
                anyNumberList.Add(Convert.ToString((char)(element + '7')));
            }

            decimalNumber /= baseD;
        }

        for (int i = anyNumberList.Count - 1; i >= 0; i--)
        {
            Console.Write(anyNumberList[i]);
        }

        Console.WriteLine();
    }

    static void Main()
    {
        Console.WriteLine("2 <= s, d <= 16");
        Console.Write("Enter s: ");
        int baseS = int.Parse(Console.ReadLine());

        Console.Write("Enter d: ");
        int baseD = int.Parse(Console.ReadLine());

        Console.Write("Enter number to convert: ");
        string number = Console.ReadLine();

        ConvertFromDecimalToAny(ConvertToDecimal(number, baseS), baseD);
    }
}