using System;

// 6. Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).
class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter a = ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter b = ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter c = ");
        double c = double.Parse(Console.ReadLine());

        double discriminant = b * b - (4 * a * c);
        double x = 0.0, x1 = 0.0, x2 = 0.0;

        if (discriminant > 0)
        {
            x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("Two real roots: \n X1 = {0,8:f2} \n X2 = {1,8:f2}", x1, x2);
        }
        else if (discriminant < 0)
        {
            Console.WriteLine("No real roots!");
        }
        else
        {
            x = (-b + Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("One real root: \n X = {0,8:f2}", x);
        }
    }
}
