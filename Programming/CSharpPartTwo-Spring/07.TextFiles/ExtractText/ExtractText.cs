// 10. Write a program that extracts from given XML file all the text without the tags. 

using System;
using System.IO;
using System.Text;

class ExtractText
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\input.xml"))
        {
            StringBuilder builder = new StringBuilder();
            char startTag = '<';
            char endTag = '>';

            for (string readLine = reader.ReadLine(); readLine != null; readLine = reader.ReadLine())
            {
                for (int i = 1; i < readLine.Length; i++)
                {
                    if (readLine[i - 1] == endTag)
                    {
                        while (readLine[i] != startTag)
                        {
                            builder.Append(readLine[i]);
                            i++;
                        }

                        if (builder.Length != 0)
                        {
                            Console.WriteLine(builder.ToString());
                            builder.Clear();
                        }
                    }
                }
            }
        }
    }
}