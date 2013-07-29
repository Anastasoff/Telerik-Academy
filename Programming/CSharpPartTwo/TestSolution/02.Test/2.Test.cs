// 12.
using System;

class SubtractAndMultiplyPolynomials
{
    public static int[] SubtractPolynomials(int[] first, int[] second)
    {
        int[] result;

        if (first.Length < second.Length)
        {
            result = new int[second.Length];
            for (int i = 0; i < second.Length; i++)
            {
                if (i >= first.Length)
                {
                    result[i] = second[i] * -1;
                    continue;
                }
                result[i] = first[i] - second[i];
            }
        }

        else
        {
            result = new int[first.Length];
            for (int i = 0; i < first.Length; i++)
            {
                if (i >= second.Length)
                {
                    result[i] = first[i] * -1;
                    continue;
                }
                result[i] = first[i] - second[i];
            }
        }
        return result;
    }

    public static int[] MultiplyPolynomials(int[] first, int[] second)
    {
        int biggestPower = (first.Length - 1) * (second.Length - 1);
        int[] result = new int[biggestPower];

        for (int i = 0; i < first.Length; i++)
        {
            for (int j = 0; j < second.Length; j++)
            {
                int power = i + j;
                result[power] += first[i] * second[j];
            }
        }

        return result;
    }

    private static void PrintPolynomial(int[] result)
    {
        Console.Write("Polynomal 1 - Polynomal 2: ");
        for (int i = result.Length - 1; i >= 0; i--)
        {
            if (i == 0)
            {
                Console.WriteLine(result[i]);
                break;
            }

            if (result[i] != 0) Console.Write(result[i] + "x^" + i + " + ");
        }
    }

    static void Main()
    {
        // (3x2 + x – 3) * (x – 1) = (3x3 – 2x2 – 4x + 3)

        int[] coefsFirst = { -3, 1, 3 }; // (3x2 + x – 3)
        int[] coefsSecond = { -1, 1, 3, 4 }; // (x – 1)

        int[] result = SubtractPolynomials(coefsFirst, coefsSecond);
        PrintPolynomial(result);

        result = MultiplyPolynomials(coefsFirst, coefsSecond);
        PrintPolynomial(result);
    }
}
