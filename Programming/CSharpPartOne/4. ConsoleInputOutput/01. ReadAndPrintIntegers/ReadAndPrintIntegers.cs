// 1. Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

class ReadAndPrintIntegers
{
    static void Main()
    {
        Console.Write("Enter first integer: ");
        int firstNum = int.Parse(Console.ReadLine());

        Console.Write("Enter second integer: ");
        int secondNum = int.Parse(Console.ReadLine());

        Console.Write("Enter third integer: ");
        int thirdNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Sum: {0}", (firstNum + secondNum + thirdNum));
    }
}
