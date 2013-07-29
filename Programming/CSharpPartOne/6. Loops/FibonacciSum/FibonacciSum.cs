/* 7. Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 
 * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
 * Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.
*/
using System;
using System.Numerics;

class FibonacciSum
{
    static void Main()
    {
        Console.Write("Enter N: ");
        BigInteger num = BigInteger.Parse(Console.ReadLine());

        BigInteger firstNum = 1;
        BigInteger secondNum = 0;
        BigInteger thirtNum = 0;
        BigInteger sum = 0;

        for (int i = 0; i <= num; i++)
        {
            int counter = i + 1;

            thirtNum = firstNum + secondNum;
            firstNum = secondNum;
            secondNum = thirtNum;
            sum += thirtNum;
        }

        Console.WriteLine("The sum is: {0}", sum);
    }
}
