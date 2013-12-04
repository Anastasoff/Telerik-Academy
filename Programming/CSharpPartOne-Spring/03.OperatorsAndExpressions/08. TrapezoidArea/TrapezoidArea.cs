// 8. Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class TrapezoidArea
{
    static void Main()
    {
        double height = 1;
        double baseA = 2;
        double baseB = 3;

        double area = ((baseA + baseB) / 2) * height;
        Console.WriteLine(area);
    }
}
