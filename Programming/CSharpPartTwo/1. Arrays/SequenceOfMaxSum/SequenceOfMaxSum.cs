// 8. Write a program that finds the sequence of maximal sum in given array. Example:
//      {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
//      Can you do it with only one loop (with single scan through the elements of the array)?

using System;

class SequenceOfMaxSum
{
    static void Main()
    {
        // input
        Console.Write("Enter array length: ");
        int arrLength = int.Parse(Console.ReadLine());
        int[] arr = new int[arrLength];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter element #{0}: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }             

        // variables
        int result = 0;
        int sum = 0;
        int tempStart = 0;
        int startIndex = 0;
        int endIndex = 0;

        // solution
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
            if (sum > result)
            {
                result = sum;
                startIndex = tempStart;
                endIndex = i;
            }

            if (sum < 0)
            {
                sum = 0;
                tempStart = i + 1;
            }
        }

        // printing
        Console.Write("Sequence: {");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
            int comma = arr.Length - 1;
            if (i != comma)
            {
                Console.Write(", ");
            }
        }

        Console.Write("}");

        Console.Write(" -> ");

        Console.Write("{");
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(arr[i]);
            int comma = endIndex;
            if (i != comma)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine("}");
    }
}
