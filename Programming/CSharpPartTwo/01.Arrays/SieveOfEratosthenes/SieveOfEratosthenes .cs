// 15. Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;

class SieveOfEratosthenes
{
    static void Main()
    {
        // input
        DateTime start = DateTime.Now;
        bool[] arr = new bool[10000000];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = true;
        }

        // algorithm
        int sqrt = (int)Math.Sqrt(arr.Length);
        for (int i = 2; i <= sqrt; i++)
        {
            if (arr[i])
            {
                for (int j = i * i; j < arr.Length; j += i)
                {
                    arr[j] = false;
                }
            }
        }

        // printing
        int counter = 0;
        for (int i = 2; i < arr.Length; i++)
        {
            if (arr[i])
            {
                Console.WriteLine(i);
                counter += 1;
            }
        }

        Console.WriteLine("Count = {0}", counter);
        DateTime end = DateTime.Now;
        Console.WriteLine("Stopwatch: {0}", end - start);
    }
}
