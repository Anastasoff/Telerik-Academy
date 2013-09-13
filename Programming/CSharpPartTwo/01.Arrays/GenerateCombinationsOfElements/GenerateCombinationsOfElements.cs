// 21. Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. 
//      Example: N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

using System;

class GenerateCombinationsOfElements
{
    static int numberOfIterations; // N
    static int numberOfCombinations; // K
    static int[] combinations; // array

    static void Main()
    {
        Console.Write("Enter N = ");
        numberOfIterations = int.Parse(Console.ReadLine());

        Console.Write("Enter K = ");
        numberOfCombinations = int.Parse(Console.ReadLine());

        combinations = new int[numberOfCombinations];

        GenerateCombinations(combinations, 0, numberOfIterations, 1);
    }

    static void GenerateCombinations(int[] variations, int currentCombination, int numberOfInterations, int numberOfVariations)
    {
        if (currentCombination == variations.Length)
        {
            PrintCombinations();
            return;
        }

        for (int counter = numberOfVariations; counter <= numberOfInterations; counter++)
        {
            variations[currentCombination] = counter;
            GenerateCombinations(variations, currentCombination + 1, numberOfInterations, counter + 1);
        }
    }

    static void PrintCombinations()
    {
        Console.Write("{0} {1}", '{', combinations[0]);
        for (int i = 1; i < numberOfCombinations; i++)
        {
            Console.Write(", {0}", combinations[i]);
        }

        Console.WriteLine(" }");
    }
}
