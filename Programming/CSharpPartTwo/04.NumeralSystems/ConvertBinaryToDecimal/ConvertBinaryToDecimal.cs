// 2. Write a program to convert binary numbers to their decimal representation.

using System;

class ConvertBinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string number = Console.ReadLine();

        int decimalNumber = 0;
        for (int i = 0; i < number.Length; i++)
        {
            decimalNumber = decimalNumber << 1;
            if (number[i] == '1')
            {
                decimalNumber ^= 1;
            }
        }

        Console.WriteLine(decimalNumber);
    }
}
