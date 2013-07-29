// 5. Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;

class PrintGreaterNumber
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        int result = Math.Max(num1, num2);

        Console.WriteLine("The greater number is: {0}", result);
    }
}
