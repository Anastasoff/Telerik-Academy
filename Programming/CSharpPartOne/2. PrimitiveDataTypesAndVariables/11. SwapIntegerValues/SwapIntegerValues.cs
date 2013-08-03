// 11. Declare two integer variables and assign them with 5 and 10 and after that exchange their values.

using System;

class SwapIntegerValues
{
    static void Main()
    {
        int firstValue = 5;
        int secondValue = 10;
        int thirdValue = firstValue;
        firstValue = secondValue;
        secondValue = thirdValue;

        Console.WriteLine(firstValue);
        Console.WriteLine(secondValue);
    }
}
