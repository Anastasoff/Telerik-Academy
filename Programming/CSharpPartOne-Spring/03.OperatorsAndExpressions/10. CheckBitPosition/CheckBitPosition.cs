// 10. Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1 -> false.

using System;

class CheckBitPosition
{
    static void Main()
    {
        int p = 5;
        int v = 1;

        bool result = ((v >> p) & 1) == 1;
        Console.WriteLine(result);
    }
}
