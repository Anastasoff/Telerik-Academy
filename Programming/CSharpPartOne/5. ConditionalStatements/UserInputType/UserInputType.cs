/* 8. Write a program that, depending on the user's choice inputs int, double or string variable. 
    If the variable is integer or double, increases it with 1. 
    If the variable is string, appends "*" at its end. 
    The program must show the value of that variable as a console output. 
    Use switch statement.
 */

using System;
using System.Globalization;
using System.Threading;

class UserInputType
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

        int inputInt;
        double inputDouble;
        string inputString;

        Console.WriteLine("Enter:");
        Console.WriteLine("[0] for integer;");
        Console.WriteLine("[1] for real number;");
        Console.WriteLine("[2] for string;");

        Console.Write("Number (0-2): ");
        byte userChoice = byte.Parse(Console.ReadLine());

        switch (userChoice)
        {
            case 0:
                Console.Write("Enter integer: ");
                inputInt = int.Parse(Console.ReadLine());
                Console.WriteLine("Result: {0}", ++inputInt);
                break;
            case 1:
                Console.Write("Enter real number: ");
                inputDouble = double.Parse(Console.ReadLine());
                Console.WriteLine("Result: {0}", ++inputDouble);
                break;
            case 2:
                Console.Write("Enter string: ");
                inputString = Console.ReadLine();
                Console.WriteLine("Result: {0}*", inputString);
                break;
            default:
                Console.WriteLine("Wrong input number!");
                Console.WriteLine("Please try again!");
                break;
        }
    }
}
