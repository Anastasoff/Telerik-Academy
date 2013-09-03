// 15. Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…[/URL]. 
//      Sample HTML fragment: ..\..\input.html and ..\..\output.html

using System;
using System.IO;

internal class ReplaceTagsInHTML
{
    private static void Main()
    {
        string str = File.ReadAllText(@"..\..\input.html");
        Console.WriteLine(str);

        str = str.Replace("<a href=\"", "[URL=\"");
        str = str.Replace("\">", "\"]");
        str = str.Replace("</a>", "[/URL]");

        File.WriteAllText(@"..\..\output.html", str);
        Console.WriteLine("File is written!");
        Console.WriteLine(str);
    }
}
