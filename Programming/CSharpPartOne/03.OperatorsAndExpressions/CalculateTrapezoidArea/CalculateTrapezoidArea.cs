using System;

// 8. Write an expression that calculates trapezoid's area by given sides a and b and height h.
class CalculateTrapezoidArea
{
    static void Main()
    {
        Console.Write("Enter h = ");
        double height = int.Parse(Console.ReadLine());
        Console.Write("Enter a = ");
        double baseA = int.Parse(Console.ReadLine());
        Console.Write("Enter b = ");
        double baseB = int.Parse(Console.ReadLine()); 

        double area = ((baseA + baseB) / 2) * height;
        Console.WriteLine("Area = {0}",area);
    }
}
