// 5. Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

class ThirdBit
{
    static void Main()
    {
        int num = 8;

        bool expr = ((num >> 3) & 1) == 1; // It is only an expression
    }
}
