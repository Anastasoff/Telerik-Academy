// 5. Write a program that finds the maximal increasing sequence in an array. 
//      Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.

using System;

class MaxIncreasingSequence 
{
    static void Main()
    {
        // input
        Console.Write("Enter array length: ");
        int arrSize = int.Parse(Console.ReadLine());
        int[] arr = new int[arrSize];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter {0} element value: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }       

        int start = 0;
        int length = 0;
        int bestStart = 0;
        int bestLength = 0;

        // solution
        for (int i = 0, j = 0; i < arr.Length; i++, j = i - 1)
        {
            int var = arr[j] + 1;
            if (arr[i] == var)
            {
                length++;
            }
            else
            {
                start = i;
                length = 1;
            }

            // bestLength and bestStart
            if (bestLength < length)
            {
                bestLength = length;
                bestStart = start;
            }
        }

        // printing
        Console.Write("Sequence: {");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
            int comma = arr.Length - 1;
            if (i != comma)
            {
                Console.Write(", ");
            }
        }

        Console.Write("}");

        Console.Write(" -> ");

        Console.Write("{");
        for (int i = bestStart; i < bestStart + bestLength; i++)
        {
            Console.Write(arr[i]);
            int comma = (bestStart + bestLength) - 1;
            if (i != comma)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine("}");
    }
}
