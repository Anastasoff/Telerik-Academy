﻿

using System;
using System.Numerics;

class Secrets
{
    static void Main()
    {
        string bigInt = Console.ReadLine();
        BigInteger number22;
        bool numberBool = BigInteger.TryParse(bigInt, out number22);

        BigInteger number = BigInteger.Abs(number22);
        BigInteger number2 = number;

        BigInteger result = 0;

        for (int i = 1; i <= 400; i++)
        {
            BigInteger digit = number % 10;
            number = number / 10;

            if (i % 2 == 0)
            {
                result = result + (digit * digit * i);
            }
            else
            {
                result = result + (digit * (i * i));
            }
        }
        Console.WriteLine(result);

        int letterLenght = (int)result % 10;
        int letterFrom = (int)result % 26;

        if (letterLenght == 0)
        {
            Console.WriteLine(number2 + " has no secret alpha-sequence");
        }

        if (letterLenght > 0)
        {

            for (int i = letterLenght; i < letterLenght * 2; i++)
            {
                if (letterFrom == 26)
                {
                    letterFrom = 0;
                }

                char letterChar = (char)(letterFrom + 65);
                Console.Write(letterChar);
                letterFrom++;
            }
            Console.WriteLine();
        }
    }
}


