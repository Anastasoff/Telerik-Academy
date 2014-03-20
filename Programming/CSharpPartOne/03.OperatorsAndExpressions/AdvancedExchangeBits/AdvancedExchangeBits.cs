using System;

// 14. * Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.
class AdvancedExchangeBits
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int integer = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(integer, 2).PadLeft(32, '0'));

        Console.Write("Enter p: ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("Enter q: ");
        int q = int.Parse(Console.ReadLine());

        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        int mask = 0;
        for (int i = 0; i < k; i++, p++, q++)
        {
            mask = 1 << p;
            int bitP = (integer & mask) >> p;

            mask = 1 << q;
            int bitQ = (integer & mask) >> q;

            if (bitP == 0)
            {
                mask = ~(1 << q);
                integer = integer & mask;
            }
            else
            {
                mask = 1 << q;
                integer = integer | mask;
            }

            if (bitQ == 0)
            {
                mask = ~(1 << p);
                integer = integer & mask;
            }
            else
            {
                mask = 1 << p;
                integer = integer | mask;
            }
        }

        Console.WriteLine("After exchange: {0}", integer);
        Console.WriteLine(Convert.ToString(integer, 2).PadLeft(32, '0'));
    }
}
