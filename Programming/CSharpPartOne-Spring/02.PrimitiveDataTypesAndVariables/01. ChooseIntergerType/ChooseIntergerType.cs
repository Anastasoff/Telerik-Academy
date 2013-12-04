/* 1. Declare five variables choosing for each of them the most appropriate of the types 
 * byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values:
 * 52130, -115, 4825932, 97, -10000. */

using System;

class ChooseIntergerType
{
    static void Main()
    {
        ushort variableOne = 52130;
        sbyte variableTwo = -115;
        uint variableThree = 4825932;
        byte variableFour = 97;
        short variableFive = -10000;

        Console.WriteLine(variableOne + ", " + variableTwo + ", " + variableThree + ", " + variableFour + ", " + variableFive);
    }
}
