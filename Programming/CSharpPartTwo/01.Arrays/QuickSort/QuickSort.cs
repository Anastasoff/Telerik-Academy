// 14. Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;
using System.Linq;

class QuickSort
{
    static List<string> Sort(List<string> arr)
    {
        List<string> less = new List<string>();
        List<string> greater = new List<string>();

        if (arr.Count > 0)
        {
            int pivot = arr.Count / 2;

            string pivotString = arr[pivot];

            for (int i = 0; i < arr.Count; i++)
            {
                if (i != pivot)
                {
                    if (string.Compare(arr[i], arr[pivot]) >= 0)
                    {
                        greater.Add(arr[i]);
                    }
                    else
                    {
                        less.Add(arr[i]);
                    }
                }
            }

            less = Sort(less);
            greater = Sort(greater);

            arr.Clear();
            arr.AddRange(less);
            arr.Add(pivotString);
            arr.AddRange(greater);
        }

        return arr;
    }

    static void Main()
    {
        Console.WriteLine("Hardcoded input data!");
        string[] stringArray = { "g", "b", "a", "f", "c", "d", "e", "i", "h", "abc", "def", "ghi" };

        List<string> sortedList = stringArray.ToList();

        sortedList = Sort(sortedList);

        Console.WriteLine(String.Join(", ", sortedList));
    }
}