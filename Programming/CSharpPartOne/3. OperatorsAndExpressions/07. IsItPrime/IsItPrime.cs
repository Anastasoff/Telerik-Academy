// 7. Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;

class IsItPrime
{
    static void Main()
    {
        // it is only an expression that is checking if intNum (intNum <= 100) is prime 
        uint intNum = 37;
        bool isItPrime = ((intNum % 2 > 0) && (intNum % 3 > 0) && (intNum % 5 > 0) && (intNum % 7 > 0)) ||
            ((intNum == 2) || (intNum == 3) || (intNum == 5) || (intNum == 7));
    }
}
