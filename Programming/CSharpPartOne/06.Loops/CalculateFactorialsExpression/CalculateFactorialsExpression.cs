using System;
using System.Numerics;

// 5. Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
class CalculateFactorialsExpression
{
    static void Main()
    {
        Console.Write("Enter N (1<N<K): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter K (K>N): ");
        int k = int.Parse(Console.ReadLine());

        BigInteger factorielKN = 1;

        for (int i = (k - n + 1); k >= i; i++)
        {
            factorielKN *= i;
        }

        BigInteger factorielNK = 1;

        for (int i = 1; n >= i; i++)
        {
            factorielNK *= i;
        }

        BigInteger result = factorielNK * factorielKN;

        Console.WriteLine("N! * K! / (K - N)! = " + result);
    }
}
