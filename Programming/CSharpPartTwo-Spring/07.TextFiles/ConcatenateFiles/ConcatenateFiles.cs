// 2. Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class ConcatenateFiles
{
    static string ReadFromFile(string file)
    {
        string content = string.Empty;
        using (StreamReader reader = new StreamReader(file))
        {
            content = reader.ReadToEnd();
        }

        return content;
    }

    static void Main()
    {
        string firstFile = @"..\..\FirstFile.txt";
        string secondFile = @"..\..\SecondFile.txt";

        using (StreamWriter writer = new StreamWriter(@"..\..\BothFiles.txt"))
        {
            writer.WriteLine(ReadFromFile(firstFile));
            writer.WriteLine(ReadFromFile(secondFile));
        }

        Console.WriteLine("File is written!");
    }
}
