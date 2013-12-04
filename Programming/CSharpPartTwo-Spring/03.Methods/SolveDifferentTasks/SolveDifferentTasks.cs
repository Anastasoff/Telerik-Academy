/*
Write a program that can solve these tasks:
- Reverses the digits of a number
- Calculates the average of a sequence of integers
- Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
- The decimal number should be non-negative
- The sequence should not be empty
- a should not be equal to 0
 */

using System;

class SolveDifferentTasks
{
    static void ReverseDigits()
    {
        Console.Write("Enter number:");
        decimal number = decimal.Parse(Console.ReadLine());
        string reverced = number.ToString();
        if (number >= 0)
        {
            Console.Write("Reversed number is: ");
            for (int i = reverced.Length - 1; i >= 0; i--)
            {
                Console.Write(reverced[i]);
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Try again with positive number!");
        }
    }

    static void GetAverage()
    {
        Console.Write("Enter sequence length: ");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Integer ({0} of {1}): ", i + 1, arr.Length);
            arr[i] = int.Parse(Console.ReadLine());
        }

        if (arr.Length > 0)
        {
            
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            double result =  (double)sum / arr.Length;
            Console.WriteLine("Average is: {0:F2}", result);
        }
        else
        {
            Console.WriteLine("The sequence should have some elements!");
        }
    }

    static void SolveEquation()
    {

        Console.Write("Enter a = ");
        decimal a = decimal.Parse(Console.ReadLine());
        if (a != 0)
        {
            Console.Write("Enter b = ");
            decimal b = decimal.Parse(Console.ReadLine());
            decimal x = b / a;
            Console.WriteLine();
            Console.WriteLine("a * x + b = 0");
            Console.WriteLine("x = {0}", x);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Input 'a' should not be equal to 0!");
        }

    }
    
    static void Main()
    {
        Console.WriteLine("Press [1] -> Reverses the digits of a number.");
        Console.WriteLine("Press [2] -> Calculates the average of a sequence of integers.");
        Console.WriteLine("Press [3] -> Solves a linear equation a * x + b = 0.");
        Console.Write("Press: ");
        int taskNumber = int.Parse(Console.ReadLine());

        if (taskNumber == 1)
        {
            ReverseDigits();
        }
        else if (taskNumber == 2)
        {
            GetAverage();
        }
        else if (taskNumber == 3)
        {
            SolveEquation();
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}

