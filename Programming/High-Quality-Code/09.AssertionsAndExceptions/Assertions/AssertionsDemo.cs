// ********************************
// <copyright file="AssertionsDemo.cs" company="Telerik Academy">
// Copyright (c) 2014 Telerik Academy. All rights reserved.
// </copyright>
//
// ********************************
namespace Assertions
{
    using System;

    /// <summary>
    /// Represents the first task from the AssertionsAndExceptions Homework
    /// </summary>
    internal class AssertionsDemo
    {
        private static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            Algorithms.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            int[] emptyArray = new int[0];
            Algorithms.SelectionSort(emptyArray); // Test sorting empty array
            int[] singleElementArray = new int[1];
            Algorithms.SelectionSort(singleElementArray); // Test sorting single element array

            Console.WriteLine(Algorithms.BinarySearch(arr, -1000));
            Console.WriteLine(Algorithms.BinarySearch(arr, 0));
            Console.WriteLine(Algorithms.BinarySearch(arr, 17));
            Console.WriteLine(Algorithms.BinarySearch(arr, 10));
            Console.WriteLine(Algorithms.BinarySearch(arr, 1000));
        }
    }
}