using System;

// 7. Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.
class CheckIfIsPrime
{
    static void Main()
    {
        Console.Write("Enter an integer <= 100: ");
        int number = int.Parse(Console.ReadLine());

        bool isItPrime = ((number % 2 > 0) && (number % 3 > 0)
            && (number % 5 > 0) && (number % 7 > 0))
            || ((number == 2) || (number == 3)
            || (number == 5) || (number == 7));

        Console.WriteLine("Is it prime? -> {0}", isItPrime);
    }
}
