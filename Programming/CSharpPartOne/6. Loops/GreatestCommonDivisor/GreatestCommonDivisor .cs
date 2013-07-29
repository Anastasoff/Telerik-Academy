// 8. Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
//Use the Euclidean algorithm (find it in Internet).

using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        
        Console.Write("Enter first number: ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int K = int.Parse(Console.ReadLine());

        int number = 0;

        do
        {
            number = N % K;
            N = K;
            K = number;
        } while (number != 0);

        Console.WriteLine(N);


        //Console.Write("Enter first number: ");
        //int numOne = int.Parse(Console.ReadLine());

        //Console.Write("Enter second number: ");
        //int numTwo = int.Parse(Console.ReadLine());

        //while (numOne != numTwo)
        //{
        //    if (numOne > numTwo)
        //    {
        //        numOne %= numOne - numTwo;
        //    }
        //    else
        //    {
        //        numTwo %= numTwo - numOne;
        //    }
        //}
        //Console.WriteLine("GCD is: {0}", numOne);
        // ! ! ! do not pass every single test
    }
}
