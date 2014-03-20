using System;

// 13. Create a program that assigns null values to an integer and to double variables. 
// Try to print them on the console, try to add some values or the null literal to them and see the result.
class NullValues
{
    static void Main()
    {
        int? nullValueOne = null;
        Console.WriteLine("Value: " + nullValueOne);

        double? nullValueTwo = null;
        Console.WriteLine("Value: " + nullValueTwo + "\n");

        Console.WriteLine("Value: " + nullValueOne + 123456);
        Console.WriteLine("Value: " + nullValueTwo + 3.14);
        Console.WriteLine("Value: " + nullValueTwo + null);
    }
}
