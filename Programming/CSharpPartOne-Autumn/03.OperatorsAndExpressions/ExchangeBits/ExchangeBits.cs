using System;

// 13. Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
class ExchangeBits
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int integer = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(integer, 2).PadLeft(32, '0'));

        int mask = 0;
        for (int i = 0; i < 3; i++)
        {
            int p = 3 + i;
            mask = 1 << p;
            int bitP = (integer & mask) >> p;

            int q = 24 + i;
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