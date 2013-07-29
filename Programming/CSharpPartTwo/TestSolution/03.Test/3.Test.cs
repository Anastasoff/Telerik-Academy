// 8. 

using System;

class Program
{
    static void Main()
    {
        short number = -3260;

        Console.WriteLine(number);

        string binary = Convert.ToString(number, 2);

        Console.WriteLine(binary);

        Console.WriteLine("The binary presentation of the given number is {0}", binary.PadLeft(16, '0'));
        
    }
}