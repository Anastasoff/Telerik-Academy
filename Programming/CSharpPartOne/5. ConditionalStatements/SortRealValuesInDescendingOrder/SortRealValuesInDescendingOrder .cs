// 4. Sort 3 real values in descending order using nested if statements.

using System;
using System.Globalization;
using System.Threading;

class SortRealValuesInDescendingOrder
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

        Console.Write("Enter first real value: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second real value: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter third real value: ");
        double c = double.Parse(Console.ReadLine());

        if (a >= b && c < a)
        {
            if (b > c)
            {
                Console.WriteLine("{0}, {1}, {2}.", a, b, c);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}.", a, c, b);
            }
        }

        if (c >= b && a <= c)
        {
            if (b > a)
            {
                Console.WriteLine("{0}, {1}, {2}.", c, b, a);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}.", c, a, b);
            }
        }

        if (b > a && c < b)
        {
            if (a > c)
            {
                Console.WriteLine("{0}, {1}, {2}.", b, a, c);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}.", b, c, a);
            }
        }
    }
}
