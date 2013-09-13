// 6. Write a program that reads from the console a string of maximum 20 characters. 
//      If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
//      Print the result string into the console.

using System;
using System.Text;

internal class ReadMaxTwentyChars
{
    private static void Main()
    {
        int maxLength = 20;
        StringBuilder result = new StringBuilder(maxLength);
        bool isCorrentLength = false;

        while (!isCorrentLength)
        {
            Console.Write("Enter a string with max {0} chars: ", maxLength);
            string inputText = Console.ReadLine();

            if (inputText.Length > maxLength)
            {
                Console.WriteLine("Please enter max {0} chars!", maxLength);
            }
            else
            {
                isCorrentLength = true;
                result.Append(inputText);
                while (result.Length < maxLength)
                {
                    result.Append('*');
                }

                Console.WriteLine("Result: {0}", result.ToString());
            }
        }
    }
}
