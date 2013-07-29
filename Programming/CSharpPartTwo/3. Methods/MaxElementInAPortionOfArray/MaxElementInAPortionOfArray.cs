using System;

class MaxElementInAPortionOfArray
{
    static int[] ReverseArray(int[] arr)
    {
        int[] sorted = SortArrayDescending(arr);
        int[] reversed = new int[sorted.Length];
        for (int index = 0; index < sorted.Length; index++)
        {
            reversed[sorted.Length - index - 1] = sorted[index];
        }

        return reversed;
    }

    static int[] SortArrayDescending(int[] arr) // use selection sort in descending order
    {
        int max = int.MinValue;
        int temp = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            max = FindMaxElement(arr, i); // use again this method

            temp = arr[max];
            arr[max] = arr[i];
            arr[i] = temp;
        }

        return arr;
    }

    static int FindMaxElement(int[] arr, int startIndex)
    {
        int maxElement = startIndex;
        for (int i = startIndex + 1; i < arr.Length; i++)
        {
            if (arr[maxElement] < arr[i])
            {
                maxElement = i;
            }
        }

        return maxElement;
    }

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();
    }

    static void Main()
    {
        int[] arr = { 1, 3, -5, 8, 9, 0, 6, 5, 7, -2, };
        int startIndex = 2;
        Console.Write("Unsorted array: ");
        PrintArray(arr);
        int result = FindMaxElement(arr, startIndex);
        Console.WriteLine("Maximal element position [{0}] with start index [{1}].", result, startIndex);
        int[] sorted = ReverseArray(arr);
        Console.Write("Sorted array in ascending order: ");
        PrintArray(sorted);
        sorted = SortArrayDescending(arr);
        Console.Write("Sorted array in descending order: ");
        PrintArray(sorted);
    }
}