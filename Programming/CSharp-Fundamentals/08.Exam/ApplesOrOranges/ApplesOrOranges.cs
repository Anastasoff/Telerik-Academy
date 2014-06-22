namespace ApplesOrOranges
{
    using System;

    internal class ApplesOrOranges
    {
        private static void Main()
        {
            string inputString = Console.ReadLine();

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] != '-')
                {
                    int currentDigit = (int)inputString[i] - 48;
                    if (currentDigit % 2 == 0)
                    {
                        evenSum += currentDigit;
                    }
                    else
                    {
                        oddSum += currentDigit;
                    }
                }
            }

            if (evenSum > oddSum)
            {
                Console.WriteLine("apples {0}", evenSum);
            }
            else if (oddSum > evenSum)
            {
                Console.WriteLine("oranges {0}", oddSum);
            }
            else
            {
                Console.WriteLine("both {0}", evenSum);
            }
        }
    }
}