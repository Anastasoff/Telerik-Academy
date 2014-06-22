// 14. Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.

using System;

class MinMaxSumAvrgPrdct
{
    static long CalculateProduct(int[] arrIntNum)
    {
        checked
        {
            long product = 1;
            for (int index = 0; index < arrIntNum.Length; index++)
            {
                product *= arrIntNum[index];
            }
            
            return product;
        }
    }

    static long CalculateSum(int[] arrIntNum)
    {
        long sum = 0;
        for (int index = 0; index < arrIntNum.Length; index++)
        {
            sum += arrIntNum[index];
        }

        return sum;
    }

    static double CalculateAverageValue(int[] arrIntNum)
    {
        double average = 0;
        for (int index = 0; index < arrIntNum.Length; index++)
        {
            average += arrIntNum[index];
        }

        average /= arrIntNum.Length;
        return average;
    }

    static int CalculateMaxValue(int[] arrIntNum)
    {
        int max = int.MinValue;
        for (int index = 0; index < arrIntNum.Length; index++)
        {
            if (arrIntNum[index] > max)
            {
                max = arrIntNum[index];
            }
        }

        return max;
    }

    static int CalculateMinValue(int[] arrIntNum)
    {
        int min = int.MaxValue;
        for (int index = 0; index < arrIntNum.Length; index++)
        {
            if (arrIntNum[index] < min)
            {
                min = arrIntNum[index];
            }
        }

        return min;
    }

    static void Main()
    {
        int[] arrIntNum = { 2, 3, -5, 999999999, 123, 1, 2, 3, -51, 213 };

        Console.WriteLine("Minimum: {0}", CalculateMinValue(arrIntNum));
        Console.WriteLine("Maximum: {0}", CalculateMaxValue(arrIntNum));
        Console.WriteLine("Average: {0:F2}", CalculateAverageValue(arrIntNum));
        Console.WriteLine("Sum: {0}", CalculateSum(arrIntNum));
        Console.WriteLine("Product: {0}", CalculateProduct(arrIntNum));
    }
}


