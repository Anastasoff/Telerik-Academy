/* 2. Which of the following values can be assigned to a variable of type float and which to a variable of type double: 
 * 34.567839023, 12.345, 8923.1234857, 3456.091? */

using System;

class AssignTheRightVariable
{
    static void Main()
    {
        double var1 = 34.567839023;
        float var2 = 12.345F;
        double var3 = 8923.1234857;
        float var4 = 3456.091F;

        Console.WriteLine("{0}, {1}, {2}, {3}", var1, var2, var3, var4);
    }
}
