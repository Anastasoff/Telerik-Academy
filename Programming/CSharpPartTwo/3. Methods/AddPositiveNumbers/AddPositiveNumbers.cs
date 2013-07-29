using System;
using System.Collections.Generic;

class AddPositiveNumbers
{
    static List<int> AddIntegers(int[] firstArr, int[] secondArr)
    {
        int minLength = firstArr.Length;
        if (secondArr.Length < firstArr.Length)
        {
            minLength = secondArr.Length;
        }

        int maxLength = firstArr.Length;
        if (secondArr.Length > firstArr.Length)
        {
            maxLength = secondArr.Length;
        }

        List<int> result = new List<int>();
        int sum = int.MinValue;
        int plusOne = 0;

        for (int i = 0; i < maxLength; i++)
        {
            if (i < minLength)
            {
                sum = firstArr[i] + secondArr[i] + plusOne;
            }
            else if (i < firstArr.Length)
            {
                sum = firstArr[i] + plusOne;
            }
            else if (i < secondArr.Length)
            {
                sum = secondArr[i] + plusOne;
            }

            if (sum >= 10)
            {
                sum = sum % 10;
                result.Add(sum);
                plusOne = 1;
            }
            else
            {
                result.Add(sum);
                plusOne = 0;
            }

        }

        if (plusOne > 0)
        {
            result.Add(plusOne);
        }

        return result;
    }

    static void Main()
    {
        int[] firstArr = { 9, 4, 1, 9, 3, 5, 2, 6, 4, 3, 6, 4, 2, 4, 6, 3, 6, 7, 8, 6, 5, 7, 9, 6, 7, 9, 9, 9, 7, 8, 6, 5, 7, 9, 6, 4, 7, 8, 6, 5, 7, 9, 6, 4 };
        int[] secondArr = { 1, 5, 6, 7, 9, 9, 9, 6, 4, 3, 6, 4, 2, 4, 6, 3, 6, 7, 8, 6, 5, 7, 9, 6, 4, 3, 6, 4, 2, 4, 6, 3, 6, 7, 8, 6, 5, 7, 9, 7, 9, 6, 4, 3, 6, 4, 2, 4, 6, 3, 6, 7, 8 };
        //int[] firstArr = { 1 };
        //int[] secondArr = { 9,9};

        List<int> result = AddIntegers(firstArr, secondArr);
        for (int i = result.Count - 1; i >= 0; i--)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }
}
