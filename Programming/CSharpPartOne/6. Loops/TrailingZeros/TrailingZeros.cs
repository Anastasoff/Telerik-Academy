/* *13. Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
        N = 10 -> N! = 3628800 -> 2
        N = 20 -> N! = 2432902008176640000 -> 4
*/

using System;
using System.Numerics;

class TrailingZeros
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int num = int.Parse(Console.ReadLine());

        BigInteger factorial = 1;

        for (int i = 1; i <= num; i++)
        {
            factorial = factorial * i;
        }

        Console.Write("N = {0} -> N! = {1} -> ", num, factorial);

        int counter = 0;

        while (true)
        {
            int result = num / 5;

            if (result != 0)
            {
                counter = counter + result;
                num = result;
            }
            else
            {
                Console.WriteLine(counter);
                break;
            }
        }
    }
}
