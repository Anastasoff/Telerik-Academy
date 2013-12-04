/* 3. Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:
 * (5.3 ; 6.01) -> false;  (5.00000001 ; 5.00000003) -> true */

using System;

class CompareTheNumbers
{
    static void Main()
    {


        float numOne = 5.3F;
        float numTwo = 6.01F;
        bool firstResult = numOne == numTwo; // False

        Console.WriteLine("Is 5.3 equal to 6.01? -> " + firstResult);

        float firstNum = 5.00000001F;
        float secondNum = 5.00000003F;

        bool secondResult = firstNum == secondNum; // True

        Console.WriteLine("Is 5.00000001 equal to 5.00000003? -> " + secondResult);
    }
}
