/* We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
	Example: n=5 (00000101), p=3, v=1 -> 13 (00001101)
	n=5 (00000101), p=2, v=0 -> 1 (00000001)
 */

using System;

class ChangeBitValue
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter position: ");
        int position = int.Parse(Console.ReadLine());
        Console.Write("Enter value: ");
        int value = int.Parse(Console.ReadLine());

        int result = (value == 0) ? (number & ~(1 << position)) : (number | 1 << position);
        Console.WriteLine("New value is: {0}", result);
    }
}
