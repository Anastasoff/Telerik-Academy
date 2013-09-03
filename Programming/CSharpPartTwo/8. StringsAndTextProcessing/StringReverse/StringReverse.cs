// 2. Write a program that reads a string, reverses it and prints the result at the console.
//      Example: "sample" -> "elpmas".

using System;
using System.Text;

internal class StringReverse
{
    private static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        StringBuilder reversedStr = new StringBuilder(str.Length);

        for (int i = str.Length - 1; i >= 0; i--)
        {
            reversedStr.Append(str[i]);
        }

        Console.WriteLine("The reversed string: {0}", reversedStr.ToString());
    }
}
