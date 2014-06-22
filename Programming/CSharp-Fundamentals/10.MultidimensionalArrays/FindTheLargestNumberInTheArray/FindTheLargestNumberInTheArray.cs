// 4. Write a program, that reads from the console an array of N integers and an integer K, 
//    sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

using System;

class FindTheLargestNumberInTheArray
{
    static void Main()
    {
        // input
        Console.Write("Enter N = ");
        int sizeN = int.Parse(Console.ReadLine());

        int[] arr = new int[sizeN];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter array[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter K = ");
        int targetK = int.Parse(Console.ReadLine());

        // sorting array
        Array.Sort(arr);

        // print sorted array
        Console.Write("Sorted array -> ");
        Console.WriteLine(String.Join(", ", arr));

        // BinarySearch method
        int index = Array.BinarySearch(arr, targetK);

        // print the result
        if (index < -1)
        {
            Console.WriteLine("The largest number in the array which is <= {0} ---> {1}.", targetK, arr[~index - 1]);
        }
        else if (~index == 0)
        {
            Console.WriteLine("{0} is not found in the array.", targetK);
        }
        else
        {
            Console.WriteLine("The largest number in the array which is <= {0} ---> {1}.", targetK, arr[index]);
        }

    }
}