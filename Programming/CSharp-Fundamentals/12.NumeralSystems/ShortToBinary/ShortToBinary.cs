// 8. Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;

class ShortToBinary
{
    static void Main()
    {
        Console.Write("Enter 16-bit number: ");
        short number = short.Parse(Console.ReadLine());

        string binary = Convert.ToString(number, 2);

        Console.WriteLine("The binary presentation of the given number is {0}", binary.PadLeft(16, '0'));
    }
}