using System;

// 3. Write a program that finds the biggest of three integers using nested if statements.
class FindTheBiggestInteger
{
    static void Main()
    {
        Console.Write("Enter first integer: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter third integer: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {

            Console.WriteLine("The biggest integer is: {0}", firstNumber);
        }
        else
        {
            if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {

                Console.WriteLine("The biggest integer is: {0}", secondNumber);
            }
            else
            {
                if (thirdNumber > firstNumber && thirdNumber > secondNumber)
                {
                    Console.WriteLine("The biggest integer is: {0}", thirdNumber);
                }
                else
                {
                    Console.WriteLine("Two or more integers are equal.");
                }
            }
        }
    }
}
