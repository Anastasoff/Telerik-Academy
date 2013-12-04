using System;
using System.Collections.Generic;

class GreedyDwarf
{
    static void Main()
    {
        string[] valleyStr = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] valley = new int[valleyStr.Length];
        for (int i = 0; i < valley.Length; i++)
        {
            valley[i] = int.Parse(valleyStr[i]);
        }

        int numberOfPatterns = int.Parse(Console.ReadLine());

        long bestSum = long.MinValue;
        for (int i = 0; i < numberOfPatterns; i++)
        {
            string[] patternsStr = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] patterns = new int[patternsStr.Length];
            for (int j = 0; j < patterns.Length; j++)
            {
                patterns[j] = int.Parse(patternsStr[j]);
            }

            bool[] isVisited = new bool[valley.Length];
            int currentSum = 0;
            int counter = 0;
            int currentIndex = 0;

            while (true)
            {
                currentSum += valley[currentIndex];
                isVisited[currentIndex] = true;
                currentIndex += patterns[counter];
                counter++;

                if (currentIndex > valley.Length - 1 || currentIndex < 0 || isVisited[currentIndex] == true)
                {
                    break;
                }

                if (counter == patterns.Length)
                {
                    counter = 0;
                }

            }

            if (bestSum < currentSum)
            {
                bestSum = currentSum;
            }
        }

        Console.WriteLine(bestSum);
    }
}