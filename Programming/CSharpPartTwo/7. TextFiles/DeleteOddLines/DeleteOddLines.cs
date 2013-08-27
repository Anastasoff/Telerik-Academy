// 9. Write a program that deletes from given text file all odd lines. The result should be in the same file.

using System;
using System.IO;
using System.Text;

class DeleteOddLines
{
    static void Main()
    {
        StringBuilder builder = new StringBuilder();

        using (StreamReader reader = new StreamReader(@"..\..\inputAndOutput.txt"))
        {
            int counter = 1;
            for (string readLine = reader.ReadLine(); readLine != null; readLine = reader.ReadLine(), counter++)
            {
                if (counter % 2 == 0)
                {
                    builder.Append(readLine).Append("\r\n");
                }
            }
        }

        using (StreamWriter writer = new StreamWriter(@"..\..\inputAndOutput.txt"))
        {
            writer.WriteLine(builder.ToString());
        }

        Console.WriteLine("File is written!");
    }
}
