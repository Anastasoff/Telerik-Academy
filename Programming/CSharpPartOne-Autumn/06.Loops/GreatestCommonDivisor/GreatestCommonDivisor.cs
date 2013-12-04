using System;

// 8. Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).
class GreatestCommonDivisor
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        while (b != 0)
        {
            int tmp = b;
            b = a % b;
            a = tmp;
        }

        Console.WriteLine("GCD is: {0}", a);
    }
}
