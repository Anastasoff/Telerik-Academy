// 5. Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

using System;

class ChechNeighborsElements
{
    static void FindBiggerElement(int[] arr, int targetPosition)
    {
        int max = int.MinValue;

        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (targetPosition == i)
            {
                max = arr[i];
                if (max > arr[i - 1] && max > arr[i + 1])
                {
                    Console.WriteLine("Element on position [{0}] is bigger than its two neighbors.", i);
                    return;
                }
            }
        }

        Console.WriteLine("It isn't bigger than its two neighbors.");
    }

    static void PrintArray(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine();
    }

    static void Main()
    {
        int targetPosition = 3;
        int[] arr = { 1, 2, 3, 4, 3, 5, 2};        
        //int[] arr = { -4, -3, -6, -12, 0, -1, -4, -9};
        //int[] arr = { 1, 2, 3, 4, 5 };
        PrintArray(arr);
        FindBiggerElement(arr, targetPosition);
    }
}
