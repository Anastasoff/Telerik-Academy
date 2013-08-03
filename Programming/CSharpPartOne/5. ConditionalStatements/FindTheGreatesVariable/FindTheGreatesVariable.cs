// 7. Write a program that finds the greatest of given 5 variables.

using System;
using System.Globalization;
using System.Threading;

class FindTheGreatesVariable
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

        Console.WriteLine("Enter 5 variables:");

        Console.Write("First: ");
        decimal var1 = decimal.Parse(Console.ReadLine());
        Console.Write("Second: ");
        decimal var2 = decimal.Parse(Console.ReadLine());
        Console.Write("Third: ");
        decimal var3 = decimal.Parse(Console.ReadLine());
        Console.Write("Fourth: ");
        decimal var4 = decimal.Parse(Console.ReadLine());
        Console.Write("Fifth: ");
        decimal var5 = decimal.Parse(Console.ReadLine());

        if (var1 > var2 && var1 > var3 && var1 > var4 && var1 > var5)
        {
            Console.WriteLine("{0} is the greatest", var1);
        }
        if (var2 > var1 && var2 > var3 && var2 > var4 && var2 > var5)
        {
            Console.WriteLine("{0} is the greates", var2);
        }
        if (var3 > var1 && var3 > var2 && var3 > var4 && var3 > var5)
        {
            Console.WriteLine("{0} is the greates", var3);
        }
        if (var4 > var1 && var4 > var2 && var4 > var3 && var4 > var5)
        {
            Console.WriteLine("{0} is the greates", var4);
        }
        if (var5 > var1 && var5 > var2 && var5 > var3 && var5 > var4)
        {
            Console.WriteLine("{0} is the greates", var5);
        }
    }
}
