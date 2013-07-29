/* 4. Write a program that reads two positive integer numbers and prints how many numbers p exist 
 * between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2. */

using System;

class PrintExistingNumbers
{
    static void Main()
    {
        Console.Write("Enter first positive integer: ");
        int firstIntNum = int.Parse(Console.ReadLine());

        Console.Write("Enter second positive integer: ");
        int secondIntNum = int.Parse(Console.ReadLine());

        // first solution
        int counter = 0;

        for (int i = firstIntNum; i <= secondIntNum; i++)
        {
            if (i % 5 == 0)
            {

                counter++;
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("{0} numbers divisible by 5.", counter);
        
        // second solution

        //int result = (secondIntNum - firstIntNum + 1) / 5 + 1;

        //Console.WriteLine("p({0}, {1}) = {2}", firstIntNum, secondIntNum, result);
    }
}
