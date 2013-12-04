// 11. Write a program that deletes from a text file all words that start with the prefix "test". 
//      Words contain only the symbols 0...9, a...z, A…Z, _.

using System;
using System.IO;
using System.Text.RegularExpressions;

class SearchAndDelete
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\input.txt"))
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\output.txt"))
            {
                for (string readLine = reader.ReadLine(); readLine != null; readLine = reader.ReadLine())
                {
                    readLine.ToLower();
                    readLine = Regex.Replace(readLine, @"\btest\w*(\s|\S)\b", string.Empty);
                    writer.WriteLine(readLine);
                }
            }
        }

        Console.WriteLine("File is written!");
    }
}
