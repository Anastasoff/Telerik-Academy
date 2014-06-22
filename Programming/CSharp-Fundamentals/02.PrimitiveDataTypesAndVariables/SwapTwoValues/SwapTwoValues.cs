using System;

// 11. Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.
class SwapTwoValues
{
    static void Main()
    {
        int a = 5;  // a = 5  -> 0 0 0 0  0 1 0 1;
        int b = 10; // b = 10 -> 0 0 0 0  1 0 1 0;

        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);

        // swap
        a ^= b; // after XOR -> a = 0 0 0 0  1 1 1 1;
        b ^= a; // after XOR -> b = 0 0 0 0  0 1 0 1;
        a ^= b; // after XOR -> a = 0 0 0 0  1 0 1 0;

        Console.WriteLine("\nAfter swapping the values:\n");
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
    }
}
