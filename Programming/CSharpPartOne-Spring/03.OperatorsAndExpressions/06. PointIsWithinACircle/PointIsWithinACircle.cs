// 6. Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;

class PointIsWithinACircle
{
    static void Main()
    {
        int radius = 5;
        int pX = 1;
        int pY = 2;
        int cX = 3;
        int cY = 4;

        int resultX = (pX - cX) * (pX - cX);
        int resultY = (pY - cY) * (pY - cY);

        bool endResult = (resultX + resultY) < radius * radius; // it is only an expression
    }
}
