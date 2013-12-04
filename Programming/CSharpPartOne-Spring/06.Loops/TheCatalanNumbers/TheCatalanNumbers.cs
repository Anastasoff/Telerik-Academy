/* 9-10. In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
 * (2*n)! / (n + 1)! * n! ; n >= 0;
 * Write a program to calculate the Nth Catalan number by given N.
 */

using System;

class NthCatalanNumber
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int num = int.Parse(Console.ReadLine());

        double nFactorial = 1;
        double reduced2nFactorial = 1;

        for (int i = num, j = (2 * num); i > 1; i--, j--)
        {
            nFactorial *= i;
            reduced2nFactorial *= j;
        }

        double catalan = reduced2nFactorial / nFactorial;

        Console.WriteLine("The Nth Catalan number is: {0}", catalan);
    }
}