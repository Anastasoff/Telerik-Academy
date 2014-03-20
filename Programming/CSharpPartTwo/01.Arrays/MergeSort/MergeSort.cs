// 13. * Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;
using System.Linq;

class MergeSort
{
    static int[] Sort(int[] arr)
    {
        if (arr.Length <= 1)
        {
            return arr;
        }

        int middleIndex = arr.Length / 2;
        int[] left = new int[middleIndex];
        int[] right = new int[arr.Length - middleIndex];

        Array.Copy(arr, left, middleIndex);
        Array.Copy(arr, middleIndex, right, 0, right.Length);

        left = Sort(left);
        right = Sort(right);

        return Merge(left, right);
    }

    static int[] Merge(int[] left, int[] right)
    {
        List<int> leftList = left.OfType<int>().ToList();
        List<int> rightList = right.OfType<int>().ToList();
        List<int> resultList = new List<int>();

        while (leftList.Count > 0 || rightList.Count > 0)
        {
            if (leftList.Count > 0 && rightList.Count > 0)
            {
                if (leftList[0] <= rightList[0])
                {
                    resultList.Add(leftList[0]);
                    leftList.RemoveAt(0);
                }
                else
                {
                    resultList.Add(rightList[0]);
                    rightList.RemoveAt(0);
                }
            }
            else if (leftList.Count > 0)
            {
                resultList.Add(leftList[0]);
                leftList.RemoveAt(0);
            }
            else if (rightList.Count > 0)
            {
                resultList.Add(rightList[0]);
                rightList.RemoveAt(0);
            }
        }

        int[] result = resultList.ToArray();
        return result;
    }

    static void PrintArray(int[] arr)
    {
        Console.Write("{");
        Console.Write(String.Join(", ", arr));
        Console.WriteLine("}");
    }

    static void Main()
    {
        Console.WriteLine("Hardcoded input data!");
        int[] arr = new int[] { 38, 27, 43, 3, 9, 82, 10, -54, -5, 0 };

        Console.WriteLine("Unsorted array:");
        PrintArray(arr);

        int[] sortedArr = Sort(arr);

        Console.WriteLine("Sorted array:");
        PrintArray(sortedArr);
    }
}
