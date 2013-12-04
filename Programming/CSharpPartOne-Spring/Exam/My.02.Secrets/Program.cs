// My solution to the second problem form the exam. Points: 6

using System;
using System.Collections.Generic;

class Secrets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int specialSum = 0;
        char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        if (n > 0 && n < 10)
        {
            specialSum = n;
        }
        else if (n > 0 && n < 100)
        {
            int firstDigit = n % 10;
            int secondDigit = n / 10;
            specialSum = firstDigit + (secondDigit * secondDigit) * 2;
        }
        else if (n > 0 && n < 1000)
        {
            int firstDigit = n % 10;
            int secondDigit = n / 10;
            secondDigit %= 10;
            int thirdDigit = n / 100;
            specialSum = firstDigit + (secondDigit * secondDigit * 2) + (thirdDigit * 3 * 3);
        }
        else if (n > 0 && n < 10000)
        {
            int firstDigit = n % 10;
            int secondDigit = n / 10;
            secondDigit %= 10;
            int thirdDigit = n / 100;
            thirdDigit %= 10;
            int fourthDigit = n / 1000;
            specialSum = firstDigit + (secondDigit * secondDigit * 2) + (thirdDigit * 3 * 3) + (fourthDigit * fourthDigit * 4);
        }
        else if (n > 0 && n < 100000)
        {
            int firstDigit = n % 10;
            int secondDigit = n / 10;
            secondDigit %= 10;
            int thirdDigit = n / 100;
            thirdDigit %= 10;
            int fourthDigit = n / 1000;
            fourthDigit %= 10;
            int fifthDigit = n / 10000;
            specialSum = firstDigit + (secondDigit * secondDigit * 2) + (thirdDigit * 3 * 3) + (fourthDigit * fourthDigit * 4) + (fifthDigit * 5 * 5);
        }


        if (specialSum == 0)
        {
            Console.WriteLine(specialSum);
            Console.WriteLine("{0} has no secret alpha-sequence", n);
        }
        else if (specialSum % 10 == 0)
        {
            Console.WriteLine(specialSum);
            Console.WriteLine("{0} has no secret alpha-sequence", n);
        }
        else
        {
            Console.WriteLine(specialSum);

            int r = specialSum;
            if (r > 26)
            {
                r -= 26;
                for (int i = r; i < alpha.Length; i++)
                {
                    Console.Write(alpha[i]);
                }
                for (int i = 0; i < alpha.Length - (r); i++)
                {

                }
            }
            Console.WriteLine();
        }
    }
}
