// 4. Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 -> true.

using System;

class CheckTheInteger
{
    static void Main()
    {
        int firstVar = 1732;
        int divideBy100 = firstVar / 100;
        bool result = divideBy100 % 10 == 7;
        Console.WriteLine(result);
    }
}