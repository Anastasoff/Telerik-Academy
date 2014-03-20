using System;
using System.Numerics;

// 13. * Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
//	N = 10 -> N! = 3628800 -> 2
//	N = 20 -> N! = 2432902008176640000 -> 4
//	Does your program work for N = 50 000?
//	Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!
class TrailingZeros
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int number = int.Parse(Console.ReadLine());

        BigInteger nFactorial = 1;

        for (int i = 1; i <= number; i++)
        {
            nFactorial = nFactorial * i;
        }

        Console.Write("N = {0} -> N! = {1} -> ", number, nFactorial);

        int counter = 0;
        while (true)
        {
            int result = number / 5;

            if (result != 0)
            {
                counter = counter + result;
                number = result;
            }
            else
            {
                Console.WriteLine(counter);
                break;
            }
        }
    }
}
