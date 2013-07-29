using System;

class FirstBiggerElement
{
    static int FindBiggerElement(int[] arr)
    {
        int max = int.MinValue;

        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (max < arr[i])
            {
                max = arr[i];
                if (max > arr[i - 1] && max > arr[i + 1])
                {
                    return i;
                }
            }
            
        }

        return -1;
    }

    static void PrintArray(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        //int[] arr = { 1, 2, 3, 4, 3, 5, 2};        
        //int[] arr = { -4, -3, -6, -12, 0, -1, -4, -9};
        int[] arr = { 1, 2, 3, 4, 5};
        int result = FindBiggerElement(arr);

        PrintArray(arr);
        if (result == -1)
        {
            Console.WriteLine("No such element.");
        }
        else
        {
            Console.WriteLine("Element with index [{0}] is bigger than its neighbors.", result);
        }
    }
}
