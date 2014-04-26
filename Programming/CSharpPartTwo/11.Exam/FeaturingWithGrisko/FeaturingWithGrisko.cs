using System;

public class Permute
{
    private static int counter = 0;

    public void Swap(ref char a, ref char b)
    {
        if (a == b)
        {
            return;
        }

        a ^= b;

        b ^= a;

        a ^= b;
    }

    public int SetPermutation(char[] list)
    {
        int x = list.Length - 1;

        bool isRepeaded = false;
        for (int i = 0; i < x; i++)
        {
            if (list[i] == list[i + 1])
            {
                isRepeaded = true;
            }
        }

        if (isRepeaded)
        {
            return 0;
        }
        else
        {
            Go(list, 0, x);

            return counter;
        }
    }

    public void Go(char[] list, int k, int m)
    {
        int i;

        if (k == m)
        {
            counter++;
        }
        else
        {
            for (i = k; i <= m; i++)
            {
                Swap(ref list[k], ref list[i]);

                Go(list, k + 1, m);

                Swap(ref list[k], ref list[i]);
            }
        }
    }
}

public class FeaturingWithGrisko
{
    public static void Main()
    {
        Permute p = new Permute();

        string c = Console.ReadLine();

        char[] c2 = c.ToCharArray();

        int result = p.SetPermutation(c2);

        Console.WriteLine(result);
    }
}