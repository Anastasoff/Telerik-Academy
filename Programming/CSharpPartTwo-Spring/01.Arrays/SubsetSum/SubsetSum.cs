// 16. * We are given an array of integers and a number S. Write a program to find if there exists a subset of the elements of the array that has a sum S. 
//      Example: arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14 -> yes (1+2+5+6)

using System;

class SubsetSum
{
    static void Main()
    {
        // input
        int[] arr = { 2, 1, 2, 4, 3, 5, 2, 6 };
        Console.Write("S = ");
        int sum = int.Parse(Console.ReadLine());

        int maxSubsets = (int)Math.Pow(2, arr.Length) - 1;
        int counter = 0;
        bool hasSum = false;        
        
        // solution
        for (int i = 1; i <= maxSubsets; i++)
        {
            int currentSum = 0;
            for (int j = 1; j <= arr.Length; j++)
            {
                if (((i >> (j - 1)) & 1) == 1)
                {
                    currentSum += arr[j - 1];
                }
            }

            if (currentSum == sum)
            {
                hasSum = true;
                counter++;
            }
        }

        // printing
        if (hasSum)
        {
            Console.Write("yes ");
            Console.WriteLine("Count = {0}", counter);
        }
        else
        {
            Console.WriteLine("no");
        }        
    }
}