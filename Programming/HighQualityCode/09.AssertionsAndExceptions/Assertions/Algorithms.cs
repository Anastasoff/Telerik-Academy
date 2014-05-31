// ********************************
// <copyright file="Algorithms.cs" company="Telerik Academy">
// Copyright (c) 2014 Telerik Academy. All rights reserved.
// </copyright>
//
// ********************************
namespace Assertions
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// Represents some search and sort algorithms - Binary search and Selection sort.
    /// </summary>
    public class Algorithms
    {
        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            if (arr == null)
            {
                throw new ArgumentNullException("array", "Value cannot be null.");
            }

            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            if (arr == null)
            {
                throw new ArgumentNullException("array", "Value cannot be null.");
            }

            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }

            Debug.Assert(IsSorted<T>(arr), "The array is not sorted correctly");
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            int minElementIndex = startIndex;

            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            Debug.Assert(
                IsMinElement<T>(arr, startIndex, endIndex, minElementIndex),
                "The FindMinElementIndex<T>() does not work correctly.");

            return minElementIndex;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(value != null, "Search value can't be null.");

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }

                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            return -1;
        }

        private static bool IsSorted<T>(T[] array)
            where T : IComparable<T>
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].CompareTo(array[i + 1]) == 1)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsMinElement<T>(T[] array, int startIndex, int endIndex, int minElementIndex)
            where T : IComparable<T>
        {
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (array[i].CompareTo(array[minElementIndex]) < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}