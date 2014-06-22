using System;

// 9. Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
class IsPointInCircleAndOutOfRectangle
{
    static void Main()
    {
        Console.Write("Point X coordinate = ");
        double pointX = double.Parse(Console.ReadLine());
        Console.Write("Point Y coordinate = ");
        double pointY = double.Parse(Console.ReadLine());

        // within the circle K[{1, 1}, R = 3]
        double circleX = 1, circleY = 1, radius = 3;
        double resultX = (pointX - circleX) * (pointX - circleX);
        double resultY = (pointY - circleY) * (pointY - circleY);
        bool InCircle = (resultX + resultY) < (radius * radius);

        // out of the rectangle [{-1, 1}, {5, -1}] -> (top = 1, left = -1, width = 6, height = 2)
        bool outOfRectangle = (pointX < -1 || pointX > 5) || (pointY < -1 || pointY > 1);

        bool endResult = InCircle && outOfRectangle;

        Console.WriteLine("Is it? -> {0}", endResult);
    }
}
