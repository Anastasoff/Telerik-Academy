// 10. Write a program that finds in given array of integers a sequence of given sum S (if present). 
//      Example: {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}
using System;

class SequenceOfGivenSum 
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

        Console.Write("Enter S: ");
        int s = int.Parse(Console.ReadLine());

        int sum = 0;
        int startIndex = 0;
        int endIndex = 0;

        // solution
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j < arr.Length; j++)
            {
                sum += arr[j];
                if (sum == s)
                {
                    startIndex = i;
                    endIndex = j;
                }

                if (sum > s)
                {
                    sum = 0;
                }
            }
        }
        
        // printing
        Console.Write("Sequence: {");
        Console.Write(String.Join(", ", arr));
        Console.Write("}");
        Console.Write(", S = {0} -> ", s);
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
