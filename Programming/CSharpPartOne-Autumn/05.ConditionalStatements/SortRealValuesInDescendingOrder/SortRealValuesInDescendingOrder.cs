using System;
using System.Globalization;
using System.Threading;

// 4. Sort 3 real values in descending order using nested if statements.
class SortRealValuesInDescendingOrder
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

        if (firstNumber >= secondNumber && thirdNumber < firstNumber)
        {
            if (secondNumber > thirdNumber)
            {
                Console.WriteLine("{0}, {1}, {2}.", firstNumber, secondNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}.", firstNumber, thirdNumber, secondNumber);
            }
        }

        if (thirdNumber >= secondNumber && firstNumber <= thirdNumber)
        {
            if (secondNumber > firstNumber)
            {
                Console.WriteLine("{0}, {1}, {2}.", thirdNumber, secondNumber, firstNumber);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}.", thirdNumber, firstNumber, secondNumber);
            }
        }

        if (secondNumber > firstNumber && thirdNumber < secondNumber)
        {
            if (firstNumber > thirdNumber)
            {
                Console.WriteLine("{0}, {1}, {2}.", secondNumber, firstNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}.", secondNumber, thirdNumber, firstNumber);
            }
        }
    }
}
