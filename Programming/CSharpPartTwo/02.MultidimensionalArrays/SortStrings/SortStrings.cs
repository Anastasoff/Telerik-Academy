// 5. You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;

class SortStrings
{
    static void Main()
    {
        // input
        Console.Write("Enter array length = ");
        int size = int.Parse(Console.ReadLine());
        string[] arr = new string[size];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter string #{0}: ", i);
            arr[i] = Console.ReadLine();
        }

        // sort with Lambda expression
        Array.Sort(arr, (x, y) => (x.Length).CompareTo(y.Length));

        // printing
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}