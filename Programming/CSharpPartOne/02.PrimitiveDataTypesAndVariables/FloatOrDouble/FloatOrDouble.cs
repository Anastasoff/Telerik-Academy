using System;

// 2. Which of the following values can be assigned to a variable of type 
// float and which to a variable of type double: 
// 34.567839023, 12.345, 8923.1234857, 3456.091?
class FloatOrDouble
{
    static void Main()
    {
        double firstDoubleVar = 34.567839023;
        float firstFloatVar = 12.345F;
        double secondDoubleVar = 8923.1234857;
        float secondFloatVar = 3456.091F;

        Console.WriteLine("double: {0,14}\nfloat: {1,9}\ndouble: {2}\nfloat: {3,9}",
            firstDoubleVar, firstFloatVar, secondDoubleVar, secondFloatVar);
    }
}
