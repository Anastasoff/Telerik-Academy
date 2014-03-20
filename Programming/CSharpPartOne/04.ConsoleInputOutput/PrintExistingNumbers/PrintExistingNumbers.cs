using System;

// 4. Write a program that reads two positive integer numbers 
// and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). 
// Example: p(17,25) = 2.
class PrintExistingNumbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int counter = 0;
        for (int i = firstNumber; i <= secondNumber; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        }

        Console.WriteLine("p({0}, {1}) = {2}", firstNumber, secondNumber, counter);
    }
}
