// ********************************
//
// <copyright file="Stats.cs" company="Telerik Academy">
// Copyright (c) 2014 Telerik Academy. All rights reserved.
// </copyright>
//
// ********************************
namespace Statistics
{
    using System;

    /// <summary>
    /// Contains methods which perform statistical calculations.
    /// </summary>
    public static class Stats
    {
        /// <summary>
        /// Returns the minimum value in <paramref name="inputArray"/>.
        /// </summary>
        /// <param name="inputArray">A sequence of values to determine the minimum value of.</param>
        /// <returns>The minimum value in the sequence.</returns>
        public static double Min(double[] inputArray)
        {
            if (inputArray == null)
            {
                throw new ArgumentNullException("The input array is null.");
            }

            if (inputArray.Length == 0)
            {
                throw new ArgumentException("The input array is empty.");
            }

            double min = double.MaxValue;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (min > inputArray[i])
                {
                    min = inputArray[i];
                }
            }

            return min;
        }

        /// <summary>
        /// Returns the maximum value in <paramref name="inputArray"/>.
        /// </summary>
        /// <param name="inputArray">A sequence of values to determine the maximum value of.</param>
        /// <returns>The maximum value in the sequence.</returns>
        public static double Max(double[] inputArray)
        {
            if (inputArray == null)
            {
                throw new ArgumentNullException("The input array is null.");
            }

            if (inputArray.Length == 0)
            {
                throw new ArgumentException("The input array is empty.");
            }

            double max = double.MinValue;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (max < inputArray[i])
                {
                    max = inputArray[i];
                }
            }

            return max;
        }

        /// <summary>
        /// Computes the average of a sequence of values.
        /// </summary>
        /// <param name="inputArray">A sequence of values to determine the average value of.</param>
        /// <returns>The average value of the elements in the sequence.</returns>
        public static double Average(double[] inputArray)
        {
            if (inputArray == null)
            {
                throw new ArgumentNullException("The input array is null.");
            }

            if (inputArray.Length == 0)
            {
                throw new ArgumentException("The input array is empty.");
            }

            double sum = 0.0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                sum += inputArray[i];
            }

            double average = sum / inputArray.Length;

            return average;
        }
    }
}