// 11. Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation. 
//      Format the output aligned right in 15 symbols.

using System;
using System.Globalization;
using System.Threading;

class FormatOutput
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // decimal
        Console.WriteLine("{0,15:D}", number);
        // hexadecimal
        Console.WriteLine("{0,15:X}", number);
        // percentage
        Console.WriteLine("{0,15:P}", number);
        // scientific notation
        Console.WriteLine("{0,15:E}", number);
    }
}
