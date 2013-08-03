// 11. Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).

using System;

class BinarySearch
{
    static void Main()
    {
        // input
        Console.WriteLine("Hardcoded input data!");

        //int target = int.Parse(Console.ReadLine());
        int target = -1;
        int[] arr = { 0, 4, -6, 22, -3, 5, 203, 55, 1, -1 };
        Array.Sort(arr);        

        //int index = Array.BinarySearch(arr, target);

        //Console.Write("Sorted array: { ");
        //Console.Write(String.Join(", ", arr));
        //Console.WriteLine(" }");        
        //Console.WriteLine("The index of {0} is {1}.", target, index);

        int min = 0; ;
        int max = arr.Length - 1;
        int index = 0;
        
        // solution
        if (max < min)
        {
            Console.WriteLine("The array is empty");
        }
        else
        {
            // algorithm
            while (max > min)
            {
                int mid = (min + max) / 2;

                if (arr[mid] < target)
                {
                    min = mid + 1;
                }
                else if (arr[mid] > target)
                {
                    max = mid - 1;
                }
                else
                {
                    index = mid;
                    break;
                }
            }
        }

        // printing
        Console.Write("Sorted array: { ");
        Console.Write(String.Join(", ", arr));
        Console.WriteLine(" }");
        Console.WriteLine("The index of {0} is {1}.", target, index);
    }
}
