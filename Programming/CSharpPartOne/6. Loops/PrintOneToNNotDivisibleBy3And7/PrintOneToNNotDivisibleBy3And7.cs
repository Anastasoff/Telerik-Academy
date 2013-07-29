// 2. Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

using System;

class PrintOneToNNotDivisibleBy3And7
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int number = int.Parse(Console.ReadLine());
        int counter = 1;

        while (counter <= number)
        {
            if (!(counter % 3 == 0 && counter % 7 == 0))  // or !(counter % (3 * 7) == 0)
            {
                Console.WriteLine(counter);
            }
            else if (counter % 3 == 0 && counter % 7 == 0)
            {
                Console.WriteLine("({0})", counter); // prints dividible by 3 and 7
            }
            counter++;
        }
    }
}
