// 11.
using System;

class Program
{
    public static int[] AddPolynomials(int[] first, int[] second)
    {
        int[] result;

        if (first.Length < second.Length)
        {
            result = new int[second.Length];
            for (int i = 0; i < second.Length; i++)
            {
                if (i >= first.Length)
                {
                    result[i] = second[i];
                    continue;
                }
                result[i] = first[i] + second[i];
            }
        }

        else
        {
            result = new int[first.Length];
            for (int i = 0; i < first.Length; i++)
            {
                if (i >= second.Length)
                {
                    result[i] = first[i];
                    continue;
                }
                result[i] = first[i] + second[i];
            }
        }
        return result;
    }

    static void PrintPolynomial(int[] result)
    {
        Console.Write("Resulting polynomal: ");

        for (int i = result.Length - 1; i >= 0; i--)
        {
            if (i == 0)
            {
                Console.WriteLine(result[i]);
                break;
            }

            if (result[i] != 0) Console.Write(result[i] + "x" + i + " + ");
        }
    }

    static void Main()
    {
        // (3x2 + x – 3) + (x – 1) = (3x2 + 2x – 4)

        int[] coefsFirst = { -3, 1, 3 }; // (3x2 + x – 3)
        int[] coefsSecond = { -1, 1 }; // (x – 1)

        int[] result = AddPolynomials(coefsFirst, coefsSecond);
        PrintPolynomial(result);
    }    
}
