// 19. * Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. 
//      Example: n = 3 -> {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}

using System;

class GeneratePermutationsOfElements
{
    static void Main()
    {
        Console.Write("Enter N = ");
        int numberOfPermutations = int.Parse(Console.ReadLine());
        int[] permutations = new int[numberOfPermutations];

        bool[] usedIndexs = new bool[permutations.Length];

        GeneratePermutations(permutations, usedIndexs, 0);
    }

    static void GeneratePermutations(int[] permutations, bool[] usedIndexs, int currentPermutation)
    {
        if (currentPermutation == permutations.Length)
        {
            PrintPermutations(permutations);
            return;
        }

        for (int counter = 0; counter < permutations.Length; counter++)
        {
            if (usedIndexs[counter])
            {
                continue;
            }

            permutations[currentPermutation] = counter;
            usedIndexs[counter] = true;
            GeneratePermutations(permutations, usedIndexs, currentPermutation + 1);
            usedIndexs[counter] = false;
        }
    }

    static void PrintPermutations(int[] permutations)
    {
        Console.Write("{ ");
        for (int i = 0; i < permutations.Length; i++)
        {
            Console.Write(permutations[i] + 1);
            if (i == permutations.Length - 1)
            {
                Console.WriteLine(" }");
            }
            else
            {
                Console.Write(", ");
            }
        }
    } 
}
