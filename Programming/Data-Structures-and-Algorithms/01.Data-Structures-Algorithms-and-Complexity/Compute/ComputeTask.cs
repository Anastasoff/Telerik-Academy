namespace Compute
{
    using System;

    public class ComputeTask
    {
        public static long Compute(int[] arr)
        {
            long count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int start = 0;
                int end = arr.Length - 1;
                while (start < end)
                {
                    if (arr[start] < arr[end])
                    {
                        start++;
                        count++;
                    }
                    else
                    {
                        end--;
                    }

                    Console.WriteLine(count);
                }
            }

            return count;
        }

        public static void Main()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            long computed = Compute(arr);
            Console.WriteLine("Result: " + computed);
        }
    }
}