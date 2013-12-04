// 15. * Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.). 
//      Use generic method (read in Internet about generic methods in C#).

using System;

class GenericMethods
{
    static T CalculateProduct<T>(params T[] arrIntNum)
    {
            dynamic product = 1;
            for (int index = 0; index < arrIntNum.Length; index++)
            {
                product *= arrIntNum[index];
            }

            return product;        
    }

    static T CalculateSum<T>(params T[] arrIntNum)
    {
        dynamic sum = 0;
        for (int index = 0; index < arrIntNum.Length; index++)
        {
            sum += arrIntNum[index];
        }

        return sum;
    }

    static T CalculateAverageValue<T>(params T[] arrIntNum)
    {
        dynamic average = 0;
        for (int index = 0; index < arrIntNum.Length; index++)
        {
            average += arrIntNum[index];
        }

        average /= arrIntNum.Length;
        return average;
    }

    static T CalculateMaxValue<T>(params T[] arrIntNum)
    {
        dynamic max = arrIntNum[0];
        for (int index = 0; index < arrIntNum.Length; index++)
        {
            if (arrIntNum[index] > max)
            {
                max = arrIntNum[index];
            }
        }

        return max;
    }

    static T CalculateMinValue<T>(params T[] arrIntNum)
    {
        dynamic min = arrIntNum[0];
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
        double[] arrIntNum = { 2, 3, -5, 999999.99, 123, 1, 2, 3, -51.1561, 213 };

        Console.WriteLine("Minimum: {0}", CalculateMinValue(arrIntNum));
        Console.WriteLine("Maximum: {0}", CalculateMaxValue(arrIntNum));
        Console.WriteLine("Average: {0:F2}", CalculateAverageValue(arrIntNum));
        Console.WriteLine("Sum: {0}", CalculateSum(arrIntNum));
        Console.WriteLine("Product: {0}", CalculateProduct(arrIntNum));
    }
}


