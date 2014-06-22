using System;

// 8. Declare two string variables and assign them with following value:
//  The "use" of quotations causes difficulties.
// Do the above in two different ways: with and without using quoted strings.
class String
{
    static void Main()
    {
        string firstStr = "The use of quotations causes difficulties.";
        Console.WriteLine(firstStr);

        string secondStr = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(secondStr);

        string thirdStr = "The \u0022use\u0022 of quotations causes difficulties.";
        Console.WriteLine(thirdStr);

        string fourthStr = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(fourthStr);
    }
}
