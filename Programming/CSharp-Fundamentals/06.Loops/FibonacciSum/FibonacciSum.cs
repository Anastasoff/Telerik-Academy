using System;
using System.Numerics;

// 7. Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
// Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.
class FibonacciSum
{
    static void Main()
    {
        Console.Write("Enter N: ");
        BigInteger number = BigInteger.Parse(Console.ReadLine());
                
        BigInteger firstNumber = 0;
        BigInteger secondNumber = 1;
        BigInteger temp = 0;
        BigInteger sum = 0;

        for (int i = 0; i < (number - 1); i++)
        {
            int counter = i + 1;

            temp = secondNumber + firstNumber;
            secondNumber = firstNumber;
            firstNumber = temp;
            sum += temp;
        }

        Console.WriteLine("The sum is: {0}", sum);
    }
}
