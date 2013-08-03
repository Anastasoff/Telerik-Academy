// 9. Write a program that finds the most frequent number in an array.
//      Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)

using System;

class MostFrequentNumber
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

        // print the array before sorting
        Console.Write("Sequence: {");
        Console.Write(String.Join(", ", arr));
        Console.Write("} -> ");

        int start = 0;
        int length = 0;
        int bestStart = 0;
        int bestLength = 0;

        // sorting
        Array.Sort(arr);

        // solution
        for (int i = 0, j = 0; i < arr.Length; i++, j = i - 1)
        {
            if (arr[i] != arr[j])
            {
                start = i;
                length = 1;
            }
            else
            {
                length++;
            }

            // bestLength and bestStart
            if (bestLength < length)
            {
                bestLength = length;
                bestStart = start;
            }
        }        
        
        // printing
        Console.Write(arr[bestStart]);
        Console.WriteLine(" ({0} times)", bestLength);
    }
}
