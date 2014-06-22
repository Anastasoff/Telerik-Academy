using System;
using System.Text;

class Brackets
{
    static void Main()
    {
        int numLines = int.Parse(Console.ReadLine());
        string indentation = Console.ReadLine();
        StringBuilder builder = new StringBuilder();
        string newLine = "\r\n";
        for (int i = 0; i < numLines; i++)
        {
            if (i > 0)
            {
                builder.Append(newLine);
            }

            builder.Append(Console.ReadLine());
        }

        builder.Replace("{", newLine + "{" + newLine);
        builder.Replace("}", newLine + "}" + newLine);
        int builderLength = 0;
        do
        {
            builderLength = builder.Length;
            builder.Replace(newLine + newLine, newLine);
            builder.Replace(" ", " ");
        }
        while (builderLength != builder.Length);

        string[] lines = builder.ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
        string indent = string.Empty;
        for (int i = 0; i < lines.Length; i++)
        {
            lines[i] = lines[i].Trim();
            if (lines[i] == string.Empty)
            {
                continue;
            }

            if (lines[i][0] != '{' && lines[i][0] != '}')
            {
                for (int j = 1; j < lines[i].Length; j++)
                {
                    if (lines[i][j] == ' ' && lines[i][j - 1] == ' ')
                    {
                        lines[i] = lines[i].Remove(j - 1, 1);
                        j--;
                    }
                }
            }

            if (lines[i] == "}")
            {
                indent = indent.Remove(0, indentation.Length);
            }

            Console.Write(indent);
            Console.WriteLine(lines[i]);

            if (lines[i] == "{")
            {
                indent = indent + indentation;
            }
        }
    }
}