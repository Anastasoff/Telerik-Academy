using System;

// 6. Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
class CheckPointsInCircle
{
    static void Main()
    {
        Console.Write("Point X coordinate = ");
        double pointX = double.Parse(Console.ReadLine());
        Console.Write("Point Y coordinate = ");
        double pointY = double.Parse(Console.ReadLine());

        Console.Write("Circle R = ");
        double radius = double.Parse(Console.ReadLine());

        bool expression = (pointX * pointX) + (pointY * pointY) <= (radius * radius);

        if (expression)
        {
            Console.WriteLine("The given point IS within a circle.");
        }
        else
        {
            Console.WriteLine("The given point IS NOT within a circle.");
        }

    }
}
