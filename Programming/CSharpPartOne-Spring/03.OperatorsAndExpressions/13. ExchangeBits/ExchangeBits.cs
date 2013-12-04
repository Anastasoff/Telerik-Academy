// 13. Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class ExchangeBits
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        // bit 3 with bit 24
        int mask = 1 << 3;
        int thirdBit = (number & mask) >> 3;

        mask = 1 << 24;
        int twentyFourthBit = (number & mask) >> 24;

        // bit 4 with bit 25
        mask = 1 << 4;
        int fourthBit = (number & mask) >> 4;

        mask = 1 << 25;
        int twentyfifthBit = (number & mask) >> 25;

        // bit 5 with bit 26
        mask = 1 << 5;
        int fifthBit = (number & mask) >> 5;

        mask = 1 << 26;
        int twentysixthBit = (number & mask) >> 26;

        // start with statements
        
        // bit 3 with bit 24

        if (thirdBit == twentyFourthBit)
        {
            Console.WriteLine(number);
            return;
        }

        if (thirdBit == 0)
        {
            mask = ~(1 << 24);
            number = number & mask;
        }
        else if (thirdBit == 1)
        {
            mask = 1 << 24;
            number = number | mask;
        }

        if (twentyFourthBit == 0)
        {
            mask = ~(1 << 3);
            number = number & mask;
        }
        else if (twentyFourthBit == 1)
        {
            mask = 1 << 3;
            number = number | mask;
        }
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        // bit 4 with bit 25

        if (fourthBit == 0)
        {
            mask = ~(1 << 25);
            number = number & mask;
        }
        else if (fourthBit == 1)
        {
            mask = 1 << 25;
            number = number | mask;
        }

        if (twentyfifthBit == 0)
        {
            mask = ~(1 << 4);
            number = number & mask;
        }
        else if (twentyfifthBit == 1)
        {
            mask = 1 << 4;
            number = number | mask;
        }
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        // bit 5 with bit 26

        if (fifthBit == 0)
        {
            mask = ~(1 << 26);
            number = number & mask;
        }
        else if (fifthBit == 1)
        {
            mask = 1 << 26;
            number = number | mask;
        }

        if (twentysixthBit == 0)
        {
            mask = ~(1 << 5);
            number = number & mask;
        }
        else if (twentysixthBit == 1)
        {
            mask = 1 << 5;
            number = number | mask;
        }

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine(number);
    }
}
