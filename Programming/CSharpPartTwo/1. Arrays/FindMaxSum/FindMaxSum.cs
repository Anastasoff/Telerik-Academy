// 6. Write a program that reads two integer numbers N and K and an array of N elements from the console. 
//  Find in the array those K elements that have maximal sum.

using System;

class FindMaxSum
{
    static void Main()
    {
        //input
        Console.WriteLine("Caution! N > K");
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int sum = 0;
        int var = int.MinValue;        
        int pos = 0;

        // filling the array
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element #{0}: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        
        // solution
        for (int i = 0; i <= n - k; i++)
        {            
            for (int j = i; j < i + k; j++)
            {
                sum += arr[j];
            }

            if (sum > var)
            {
                var = sum;
                pos = i;
            }

            sum = 0;
        }

        // printing
        Console.Write("The elements which have max sum are: ");
        for (int i = pos; i < pos + k; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();
    }
}
