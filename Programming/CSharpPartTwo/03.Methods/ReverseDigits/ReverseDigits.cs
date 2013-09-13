// 7. Write a method that reverses the digits of given decimal number. 
//      Example: 256 -> 652

using System;

class ReverseDigits
{
    private static void ReverseNumber(decimal number)
    {
        string reverced = number.ToString();

        for (int i = reverced.Length - 1; i >= 0; i--)
        {
            Console.Write(reverced[i]);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        decimal number = decimal.Parse(Console.ReadLine());

        ReverseNumber(number);
    }
}