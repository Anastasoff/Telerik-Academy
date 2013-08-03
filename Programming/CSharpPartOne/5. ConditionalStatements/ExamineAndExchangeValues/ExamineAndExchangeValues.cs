// 1. Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

using System;

class ExamineAndExchangeValues
{
    static void Main()
    {
        Console.Write("Enter first integer: ");
        int intVarOne = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer: ");
        int intVarTwo = int.Parse(Console.ReadLine());
        int varThree = 0;

        if (intVarOne > intVarTwo)
        {
            varThree = intVarOne;
            intVarOne = intVarTwo;
            intVarTwo = varThree;
        }
        Console.WriteLine("-~-~-~-~-~-~-~-~-~-~-~-~-~-~");
        Console.WriteLine("First integer is: {0}", intVarOne);
        Console.WriteLine("Second integer is: {0}", intVarTwo);
    }
}
