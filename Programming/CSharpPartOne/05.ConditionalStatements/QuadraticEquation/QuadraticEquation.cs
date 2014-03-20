using System;
using System.Globalization;
using System.Text;
using System.Threading;

// 6. Write a program that enters the coefficients a, b and c of a quadratic equation a*x2 + b*x + c = 0 
// and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.
class QuadraticEquation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Enter a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c = ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("{0}x\u00B2 + {1}x + {2} = 0", a, b, c);

        double discriminant = b * b - (4 * a * c);
        double x, x1, x2;

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
