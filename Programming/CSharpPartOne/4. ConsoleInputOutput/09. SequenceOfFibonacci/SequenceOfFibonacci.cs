// 9. Write a program to print the first 100 members of the sequence of Fibonacci: 
// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;
using System.Numerics;

class Fibunacci
{
    static void Main()
    {
        BigInteger firstNum = 1;
        BigInteger secondNum = 0;
        BigInteger thirtNum = 0;

        Console.WriteLine("The first 100 members of the sequence of Fibonacci:");

        for (int i = 0; i < 100; i++)
        {
            int counter = i + 1;
            Console.WriteLine("{0,4}:  {1}", counter, thirtNum);
            thirtNum = firstNum + secondNum;
            firstNum = secondNum; 
            secondNum = thirtNum;
        }
    }
}
