/* 9. We are given 5 integer numbers. 
    Write a program that checks if the sum of some subset of them is 0. 
    Example: 3, -2, 1, 1, 8 -> 1+1-2=0.
*/

using System;

class SubsetOfZero
{
    static void Main()
    {
        Console.WriteLine("Enter 5 integer number:");
        Console.Write("First = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Second = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Third = ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("Fourth = ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Fifth = ");
        int e = int.Parse(Console.ReadLine());

        Console.WriteLine("Result:");

        // 2 digits
        if ((a + b) == 0)
        {
            Console.WriteLine("{0} and {1} have 0 subset", a, b);
        }
        if ((a + c) == 0)
        {
            Console.WriteLine("{0} and {1} have 0 subset", a, c);
        }
        if ((a + d) == 0)
        {
            Console.WriteLine("{0} and {1} have 0 subset", a, d);
        }
        if ((a + e) == 0)
        {
            Console.WriteLine("{0} and {1} have 0 subset", a, e);
        }
        if ((b + c) == 0)
        {
            Console.WriteLine("{0} and {1} have 0 subset", b, c);
        }
        if ((b + d) == 0)
        {
            Console.WriteLine("{0} and {1} have 0 subset", b, d);
        }
        if ((b + e) == 0)
        {
            Console.WriteLine("{0} and {1} have 0 subset", b, e);
        }
        if ((c + d) == 0)
        {
            Console.WriteLine("{0} and {1} have 0 subset", c, d);
        }
        if ((c + e) == 0)
        {
            Console.WriteLine("{0} and {1} have 0 subset", c, e);
        }
        if ((d + e) == 0)
        {
            Console.WriteLine("{0} and {1} have 0 subset", d, e);
        }

        // 3 digits
        if ((a + b + c) == 0)
        {
            Console.WriteLine("{0}, {1} and {2} have 0 subset", a, b, c);
        }
        if ((a + b + d) == 0)
        {
            Console.WriteLine("{0}, {1} and {2} have 0 subset", a, b, d);
        }
        if ((a + b + e) == 0)
        {
            Console.WriteLine("{0}, {1} and {2} have 0 subset", a, b, e);
        }
        if ((b + c + d) == 0)
        {
            Console.WriteLine("{0}, {1} and {2} have 0 subset", b, c, d);
        }
        if ((b + c + e) == 0)
        {
            Console.WriteLine("{0}, {1} and {2} have 0 subset", b, c, e);
        }
        if ((b + d + e) == 0)
        {
            Console.WriteLine("{0}, {1} and {2} have 0 subset", b, d, e);
        }
        if ((c + d + e) == 0)
        {
            Console.WriteLine("{0}, {1} and {2} have 0 subset", c, d, e);
        }
        if ((c + a + d) == 0)
        {
            Console.WriteLine("{0}, {1} and {2} have 0 subset", c, a, d);
        }
        if ((c + a + e) == 0)
        {
            Console.WriteLine("{0}, {1} and {2} have 0 subset", c, a, e);
        }
        if ((d + a + e) == 0)
        {
            Console.WriteLine("{0}, {1} and {2} have 0 subset", d, a, e);
        }

        // 4 digits
        if ((a + b + c + d) == 0)
        {
            Console.WriteLine("{0}, {1}, {2} and {3} have 0 subset", a, b, c, d);
        }
        if ((a + c + d + e) == 0)
        {
            Console.WriteLine("{0}, {1}, {2} and {3} have 0 subset", a, c, d, e);
        }
        if ((a + b + d + e) == 0)
        {
            Console.WriteLine("{0}, {1}, {2} and {3} have 0 subset", a, b, d, e);
        }
        if ((b + c + d + e) == 0)
        {
            Console.WriteLine("{0}, {1}, {2} and {3} have 0 subset", b, c, d, e);
        }
        if ((b + a + d + e) == 0)
        {
            Console.WriteLine("{0}, {1}, {2} and {3} have 0 subset", b, a, d, e);
        }

        // 5 digits
        if ((a + b + c + d + e) == 0)
        {
            Console.WriteLine("{0}, {1}, {2}, {3} and {4} have 0 subset", a, b, c, d, e);
        }

        Console.WriteLine("No zero subset.");
        Console.WriteLine("Please try with other integer numbers!");
    }
}
