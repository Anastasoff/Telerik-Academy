/*
10. Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 
* Sample input:
Hi!
* Expected output:
\u0048\u0069\u0021
*/

using System;
using System.Text;

internal class ConvertStringToUnicodeChars
{
    private static void Main()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            char character = text[i];
            int charCode = (int)character;
            result.Append(string.Format("{0}{1}", @"\u", charCode.ToString("X4")));
        }

        Console.WriteLine("Output: {0}", result.ToString());
    }
}
