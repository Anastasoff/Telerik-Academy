using System;
using System.Numerics;

// 9. Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
class SequenceOfFibonacci 
{
    static void Main()
    {
        BigInteger f0 = 0;
        BigInteger f1 = 1;

        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(f0);
            f0 = f0 + f1;
            f1 = f0 - f1;
        }
    }
}
