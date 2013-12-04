using System;

// 1. Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.
class ExamineAndExchangeValues
{
    static void Main()
    {
        Console.Write("Enter first integer: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int tempNumber = 0;
        if (firstNumber > secondNumber)
        {
            tempNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = tempNumber;
        }

        Console.WriteLine("-~-~-~-~-~-~-~-~-~-~-~-~-~-~");
        Console.WriteLine("First integer is: {0}", firstNumber);
        Console.WriteLine("Second integer is: {0}", secondNumber);
    }
}
