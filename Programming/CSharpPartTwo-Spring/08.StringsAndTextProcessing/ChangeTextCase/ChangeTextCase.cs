/*
5. You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. 
The tags cannot be nested. 
Example:

We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

The expected result:

We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
*/

using System;
using System.Text;

internal class ChangeTextCase
{
    private static void Main()
    {
        Console.WriteLine("Enter a text:");
        string text = Console.ReadLine();

        StringBuilder result = new StringBuilder();
        string uppercaseTag = "<upcase>";

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == uppercaseTag[0])
            {
                i += uppercaseTag.Length;
                while (text[i] != uppercaseTag[0])
                {
                    result.Append(text[i].ToString().ToUpper());
                    i++;
                }

                i += uppercaseTag.Length;
            }
            else
            {
                result.Append(text[i].ToString());
            }
        }

        Console.WriteLine(result);
    }
}
