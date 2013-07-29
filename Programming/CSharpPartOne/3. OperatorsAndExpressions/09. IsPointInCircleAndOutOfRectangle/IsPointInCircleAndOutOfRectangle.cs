// 9. Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class IsPointInCircleAndOutOfRectangle
{
    static void Main()
    {
        int pX = 1;
        int pY = 2;
        
        int cX = 1;
        int cY = 1;
        int radius = 3;
        
        int resultX = (pX - cX) * (pX - cX);
        int resultY = (pY - cY) * (pY - cY);
        bool InCircle = (resultX + resultY) < radius * radius;

        bool outOfRectangle = (pX < -1 || pX > 5) || (pY < -1 || pY > 1);

        bool endResult = InCircle && outOfRectangle;

        Console.WriteLine(endResult);
    }
}
