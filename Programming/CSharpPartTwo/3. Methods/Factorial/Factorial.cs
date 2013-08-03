// 10. Write a program to calculate n! for each n in the range [1..100]. 
//      Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

using System;
using System.Collections.Generic;

class Factorial
{
    static void Main()
    {

        Console.Write("n! = ");
        int factoriel = int.Parse(Console.ReadLine());

        int[] arr = CalculateFactorial(factoriel);

        Console.Write("{0}! = ", factoriel);
        PrintFactorial(arr);
    }

    static int[] CalculateFactorial(int n)
    {
        int[] arr = { 1 };
        for (int i = 1; i <= n; i++)
        {
            List<int> list = new List<int>();
            int adder = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                list.Add((arr[j] * i + adder) % 10);
                adder = (arr[j] * i + adder) / 10;
            }

            while (adder > 0)
            {
                list.Add(adder % 10);
                adder = adder / 10;

            }

            arr = list.ToArray();
            list.Clear();
        }

        return arr;
    }

    static void PrintFactorial(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write(arr[i]);
        }

        Console.WriteLine();
    }
}

