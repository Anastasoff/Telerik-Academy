using System;

// 4. Write a program that calculates N!/K! for given N and K (1<K<N).
class FactorialDivision
{
    static void Main()
    {
        Console.WriteLine("1 < K < N");
        Console.Write("Enter N: ");
        int nFactorial = int.Parse(Console.ReadLine());

        Console.Write("Enter K: ");
        int kFactoriel = int.Parse(Console.ReadLine());

        int result = 1;
        for (int i = 0; i < (nFactorial - kFactoriel); i++)
        {
            result *= (nFactorial - i);
        }

        Console.WriteLine("{0}!/{1}! = {2}", nFactorial, kFactoriel, result);
    }
}
