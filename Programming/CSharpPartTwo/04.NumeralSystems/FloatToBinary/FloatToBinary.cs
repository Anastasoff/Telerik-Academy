// 9. * Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format (the C# type float). 
//      Example: -27,25 -> sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

class FloatToBinary
{
    static int FindSign(float number)
    {
        if (number >= 0)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }

    static string FindExponent(float number)
    {
        if (number < 0)
        {
            number = -number;
        }

        string binary = Convert.ToString((int)number, 2);
        int bias = 127;
        int exponent = binary.Length - 1 + bias;
        string stringExponent = Convert.ToString(exponent, 2);

        return stringExponent;
    }

    static List<int> FindMantissa(float number)
    {
        List<int> mantissaList = new List<int>();
        if (number < 0)
        {
            number = -number;
        }
        
        int firstPart = (int)number;
        while (firstPart >= 2)
        {
            mantissaList.Add(firstPart % 2);
            firstPart /= 2;
        }
        
        mantissaList.Reverse();
        float secondPart = number % 1;
        while (secondPart != 0.0)
        {
            if (2 * secondPart >= 1)
            {
                mantissaList.Add(1);
            }
            else
            {
                mantissaList.Add(0);
            }
            secondPart = (2 * secondPart) % 1;
        }
        
        while (mantissaList.Count < 23)
        {
            mantissaList.Add(0);
        }

        return mantissaList;
    }

    static void PrintResult(int sign, string exponent, List<int> mantissaList)
    {
        Console.WriteLine("sign = {0}", sign);
        Console.WriteLine("exponent = {0}", exponent);
        Console.Write("mantissa = ");
        for (int i = 0; i < mantissaList.Count; i++)
        {
            Console.Write(mantissaList[i]);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter floating-point number: ");
        float number = float.Parse(Console.ReadLine());
        int sign = 0;
        string exponent = string.Empty;
        List<int> mantissaList = new List<int>();

        sign = FindSign(number);
        exponent = FindExponent(number);
        mantissaList = FindMantissa(number);

        PrintResult(sign, exponent, mantissaList);
    }
}

