/* 
 4. Write methods that calculate the surface of a triangle by given:
    - Side and an altitude to it; 
    - Three sides; 
    - Two sides and an angle between them. 
    Use System.Math.
*/

using System;

class CalculateSurfaceOfTriangle
{
    private static void TwoSidesAndAngle()
    {
        // Two sides and an angle between them; - S = (a * b * sin(angle)) / 2
        Console.Write("Enter first side: ");
        double firstSide = double.Parse(Console.ReadLine());
        Console.Write("Enter second side: ");
        double secondSide = double.Parse(Console.ReadLine());
        Console.Write("Enter angle between them: ");
        double angle = double.Parse(Console.ReadLine());

        double area = (firstSide * secondSide * Math.Sin(Math.PI * angle / 180)) / 2;

        PrintResult(area);
    }

    private static void ThreeSides()
    {
        // Three sides; - S = sqrt(p * (p - a) * (p - b) * (p - c)); p = (a + b + c) / 2
        Console.Write("Enter a:");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Enter b:");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Enter c:");
        double sideC = double.Parse(Console.ReadLine());

        double semiP = (sideA + sideB + sideC) / 2;
        double area = Math.Sqrt(semiP * (semiP - sideA) * (semiP - sideB) * (semiP - sideC));

        PrintResult(area);
    }

    private static void SideAndAltitude()
    {
        // Side and an altitude to it; - S = (a * h) / 2
        Console.Write("Enter a: ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Enter h: ");
        double height = double.Parse(Console.ReadLine());

        double area = (sideA * height) / 2;

        PrintResult(area);
    }

    static void Input()
    {
        Console.WriteLine("Choose how to calculate the surface of a triangle:");
        Console.WriteLine(" ---> [1] By side and altitude");
        Console.WriteLine(" ---> [2] By three sides");
        Console.WriteLine(" ---> [3] Two sides and an angle between them");
        Console.Write("Enter: ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                SideAndAltitude();
                break;
            case 2:
                ThreeSides();
                break;
            case 3:
                TwoSidesAndAngle();
                break;
            default:
                break;
        }
    }

    static void PrintResult(double result)
    {
        Console.WriteLine("S = {0:F2}", result);
    }

    static void Main()
    {
        Input();
    }
}