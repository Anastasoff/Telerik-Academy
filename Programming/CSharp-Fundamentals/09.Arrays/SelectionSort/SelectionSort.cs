// 7. Sorting an array means to arrange its elements in increasing order. 
//      Write a program to sort an array. Use the "selection sort" algorithm: 
//      Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;

class SelectionSort
{
    static void Main()
    {
        // input
        Console.Write("Enter array length: ");
        int arrLength = int.Parse(Console.ReadLine());
        int[] arr = new int[arrLength];
        int min = 0;
        int temp = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter element #{0}: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(new string('-', 30));
            
        // Selection Sort
        for (int i = 0; i < arr.Length - 1; i++)
        {
            min = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[min])
                {
                    min = j;
                }
            }

            temp = arr[i];
            arr[i] = arr[min];
            arr[min] = temp;
        }

        // printing
        Console.WriteLine("Array after sorting:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Element #{0}: {1}", i, arr[i]);
        }
    }
}
