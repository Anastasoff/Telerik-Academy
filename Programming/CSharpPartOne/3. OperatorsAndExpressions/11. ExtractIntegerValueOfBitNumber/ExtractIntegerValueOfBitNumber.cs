// 11. Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2; -> value=1.

using System;

class ExtractIntegerValueOfBitNumber
{
    static void Main()
    {
        int i = 5;
        int b = 2;

        int mask = 1 << b;
        int result = mask & i;
        result = result >> b;

        Console.WriteLine(result);
    }
}
