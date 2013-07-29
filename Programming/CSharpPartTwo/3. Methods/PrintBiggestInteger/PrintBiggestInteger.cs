using System;

class PrintBiggestInteger
{
    static int GetMax(int first, int second)
    {
        int biggest = first;
        if (second > first)
        {
            biggest = second;
        }

        return biggest;
    }

    static void Main()
    {
        Console.Write("Enter how many integers you want to compare: ");
        int arrSize = int.Parse(Console.ReadLine());
        int[] arr = new int[arrSize];
        Console.WriteLine("Please enter {0} integer numbers!", arrSize);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter integer ({0} of {1}): ", i + 1, arr.Length);
            arr[i] = int.Parse(Console.ReadLine());
        }

        int biggest = GetMax(arr[0], arr[1]);
        //biggest = GetMax(biggest, arr[2]);

        for (int i = 2; i < arr.Length; i++)
        {
            int number = arr[i];
            biggest = GetMax(biggest, number);
        }

        Console.WriteLine("The biggest integer is {0}.", biggest);
    }
}
