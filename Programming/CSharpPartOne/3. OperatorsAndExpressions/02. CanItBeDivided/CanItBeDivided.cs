// 2. Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

using System;

class CanItBeDivided
{
    static void Main()
    {


        Console.Write("Enter integer: ");
        int integer = int.Parse(Console.ReadLine());
        bool firstDiv = integer % 5 == 0;
        bool secondDiv = integer % 7 == 0;
        bool divide = firstDiv && secondDiv;
        Console.WriteLine(divide);

        //Console.Write("Enter integer: ");
        //int integer = int.Parse(Console.ReadLine());
        //if (integer % 35 == 0)
        //{
        //    Console.WriteLine(true);
        //}
        //else
        //{
        //    Console.WriteLine(false);
        //}
    }
}
