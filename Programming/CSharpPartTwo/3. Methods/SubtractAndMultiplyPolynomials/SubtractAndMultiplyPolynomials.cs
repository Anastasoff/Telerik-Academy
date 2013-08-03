// 12. Extend the program to support also subtraction and multiplication of polynomials.

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
        // (2x^3 + 5x^2 + x – 2) -/* (3x^2 + x – 3) = result

        int[] coefsFirst = { -2, 1, 5, 2 }; // (2x^3 + 5x^2 + x – 2)
        int[] coefsSecond = { -3, 1, 3 }; // (3x^2 + x – 3)

        int[] result = SubtractPolynomials(coefsFirst, coefsSecond);
        Console.Write("First - second: ");
        PrintPolynomial(result);

        Console.Write("First * second: ");
        result = MultiplyPolynomials(coefsFirst, coefsSecond);
        PrintPolynomial(result);
    }
}