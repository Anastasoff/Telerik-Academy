// 2. Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. 
// Use a sequence of if statements.

using System;
using System.Globalization;
using System.Threading;

class ShowSignOfInteger
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

        Console.Write("Enter first real number: ");
        double firstNum = double.Parse(Console.ReadLine());
        Console.Write("Enter second real number: ");
        double secondNum = double.Parse(Console.ReadLine());
        Console.Write("Enter third real number: ");
        double thirdNum = double.Parse(Console.ReadLine());

        if ((firstNum > 0) ^ (secondNum > 0) ^ (thirdNum > 0))
        {
            Console.WriteLine("The sign is: + ");
        }
        else
        {
            Console.WriteLine("The sign is: - ");
        }
    }
}
