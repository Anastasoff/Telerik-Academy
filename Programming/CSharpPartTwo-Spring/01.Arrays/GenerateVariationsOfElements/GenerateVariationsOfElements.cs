// 20. Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. 
//      Example: N = 3, K = 2 -> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

using System;

class GenerateVariationsOfElements
{
    static int numberOfIterations;
    static int numberOfVariations;
    static int[] variations;

    static void Main()
    {
        Console.Write("Enter N = ");
        numberOfIterations = int.Parse(Console.ReadLine());

        Console.Write("Enter K = ");
        numberOfVariations = int.Parse(Console.ReadLine());

        variations = new int[numberOfVariations];

        GenerateVariations(0);
    }

    static void GenerateVariations(int currentVariation)
    {
        if (currentVariation == numberOfVariations)
        {
            PrintVariations();
            return;
        }

        for (int counter = 1; counter <= numberOfIterations; counter++)
        {
            variations[currentVariation] = counter;
            GenerateVariations(currentVariation + 1);
        }
    }

    static void PrintVariations()
    {
        Console.Write("{0} {1}", '{', variations[0]);
        for (int i = 1; i < numberOfVariations; i++)
        {
            Console.Write(", {0}", variations[i]);
        }

        Console.WriteLine(" }");
    }
}