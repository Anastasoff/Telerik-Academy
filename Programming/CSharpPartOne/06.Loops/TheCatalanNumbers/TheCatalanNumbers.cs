using System;

// 09-10. In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
// (2n)! / (n + 1)!n!
//Write a program to calculate the Nth Catalan number by given N.
class TheCatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int number = int.Parse(Console.ReadLine());

        double nFactorial = 1;
        double reduced2nFactorial = 1;

        for (int i = number, j = (2 * number); i > 1; i--, j--)
        {
            nFactorial *= i;
            reduced2nFactorial *= j;
        }

        double result = reduced2nFactorial / nFactorial;

        Console.WriteLine("The Nth Catalan number is: {0}", result);
    }
}
