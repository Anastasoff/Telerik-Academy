// 5. Write a program that calculates N! * K! / (K-N)! for given N and K (1<N<K).

using System;
using System.Numerics;

class CalculateFactorialsExpression
{
    static void Main()
    {
        Console.Write("Enter N (1 < N < K): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter K (K > N): ");
        int k = int.Parse(Console.ReadLine());

        BigInteger factoriel1 = 1;

        for (int i = (k - n + 1); k >= i; i++)
        {
            factoriel1 *= i;
        }

        BigInteger factoriel2 = 1;

        for (int i = 1; n >= i; i++)
        {
            factoriel2 *= i;
        }

        BigInteger result = factoriel2 * factoriel1;

        Console.WriteLine("N! * K! / (K - N)! = " + result);
    }
}
