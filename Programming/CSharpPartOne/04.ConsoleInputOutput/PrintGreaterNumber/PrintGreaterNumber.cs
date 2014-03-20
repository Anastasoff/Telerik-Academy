using System;

// 5. Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.
class PrintGreaterNumber
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int greater = Math.Max(firstNumber, secondNumber);
        Console.WriteLine("The greater number is: {0}", greater);
    }
}
