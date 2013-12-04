// 7. Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file.
//      Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;

class ReplaceSubstring
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\input.txt"))
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\output.txt"))
            {
                string readLine = reader.ReadLine();
                while (readLine != null)
                {
                    readLine = readLine.Replace("start", "finish");
                    writer.WriteLine(readLine);
                    readLine = reader.ReadLine();
                }
            }
        }

        Console.WriteLine("File is written!");
    }
}