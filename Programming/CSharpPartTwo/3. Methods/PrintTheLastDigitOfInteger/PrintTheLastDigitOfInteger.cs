using System;

class PrintTheLastDigitOfInteger
{
    static string FindLastDigit(int number)
    {
        string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string word = string.Empty;
        int lastDigit = number % 10;
        if (lastDigit < 0) // chech if number is negative
        {
            lastDigit = -lastDigit; // change number's sign
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            if (lastDigit == i)
            {
                word = numbers[i];
            }
        }

        return word;
    }

    static void Main()
    {
        Console.Write("Enter integer number: ");        
        int number = int.Parse(Console.ReadLine());
        string word = FindLastDigit(number);
        Console.WriteLine(" {0} -> \"{1}\"", number, word);
    }
}