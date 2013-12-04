using System;
using System.Globalization;
using System.Threading;

// 2. Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.
class ShowSignOfInteger
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

        Console.Write("Enter first real number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter second real number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter third real number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        if ((firstNumber > 0) ^ (secondNumber > 0) ^ (thirdNumber > 0))
        {
            Console.WriteLine("The sign is: + ");
        }
        else
        {
            Console.WriteLine("The sign is: - ");
        }
    }
}
