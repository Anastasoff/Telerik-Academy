using System;

// 3. Write a program that safely compares floating-point numbers with precision of 0.000001. 
// Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true

class FloatPrecision
{
    static void Main()
    {
        float firstFloatVar = 5.3F;
        float secondFloatVar = 6.01F;
        Console.WriteLine(firstFloatVar == secondFloatVar);

        float thirdFloatVar = 5.00000001F;
        float fourthFloatVar = 5.00000003F;
        Console.WriteLine(thirdFloatVar == fourthFloatVar);
    }
}
