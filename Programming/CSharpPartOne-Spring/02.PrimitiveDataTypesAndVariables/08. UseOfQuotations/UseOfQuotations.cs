/* 8. Declare two string variables and assign them with following value: 
 * "The "use" of quotations causes difficulties." Do the above in two different ways: with and without using quoted strings. */

using System;

class UseOfQuotations
{
    static void Main()
    {
        string stringVarOne = "The use of quotations causes difficulties.";
        Console.WriteLine(stringVarOne);

        string stringVarTwo = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(stringVarTwo);

        string stringVarThree = "The \u0022use\u0022 of quotations causes difficulties.";
        Console.WriteLine(stringVarThree);

        string stringVarFour = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(stringVarFour);

    }
}
