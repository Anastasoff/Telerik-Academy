﻿/* 7. Declare two string variables and assign them with “Hello” and “World”. 
 * Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval). 
 * Declare a third string variable and initialize it with the value of the object variable (you should perform type casting). */

using System;

class DeclaringStringVariable
{
    static void Main()
    {
        string stringVarOne = "Hello";
        string stringVarTwo = "World";
        object objectVar = stringVarOne + " " + stringVarTwo;
        string stringVarThree = (string)objectVar;
        Console.WriteLine(stringVarThree + "!");
    }
}
