using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirlsGoneWild
{
    class Solution
    {
        private static HashSet<string> result = new HashSet<string>();
        static void Main(string[] args)
        {
            int numberOfShirts = int.Parse(Console.ReadLine());
            var letters = Console.ReadLine().ToCharArray();
            int numberOfGirls = int.Parse(Console.ReadLine());

            GeneratePermutations(letters, 0);

            Console.WriteLine(result.Count);

            StringBuilder sb = new StringBuilder();
            foreach (var item in result)
            {
                sb.AppendLine(item);
            }

            Console.WriteLine(sb);
        }

        static void GeneratePermutations<T>(T[] arr, int k)
        {
            if (k >= arr.Length)
            {
                result.Add(string.Join(" ", arr));
            }
            else
            {
                GeneratePermutations(arr, k + 1);
                for (int i = k + 1; i < arr.Length; i++)
                {
                    Swap(ref arr[k], ref arr[i]);
                    GeneratePermutations(arr, k + 1);
                    Swap(ref arr[k], ref arr[i]);
                }
            }
        }

        static void Print<T>(T[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }

        static void Swap<T>(ref T first, ref T second)
        {
            T oldFirst = first;
            first = second;
            second = oldFirst;
        }
    }
}
