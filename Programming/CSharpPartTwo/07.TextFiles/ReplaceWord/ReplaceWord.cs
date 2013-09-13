// 8. Modify the solution of the previous problem to replace only whole words (not substrings).

using System;
using System.IO;
using System.Text.RegularExpressions;

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
                    readLine = Regex.Replace(readLine, @"\b(start)\b", "finish");
                    writer.WriteLine(readLine);
                    readLine = reader.ReadLine();
                }
            }
        }

        Console.WriteLine("File is written!");
    }
}
