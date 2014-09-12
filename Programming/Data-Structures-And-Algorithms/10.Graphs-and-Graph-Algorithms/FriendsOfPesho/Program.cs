using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsOfPesho
{
    class Program
    {


        static void Main(string[] args)
        {
            string[] firstRow = Console.ReadLine().Split(' ');
            int N = int.Parse(firstRow[0]);
            int M = int.Parse(firstRow[1]);
            int H = int.Parse(firstRow[2]);

            int[,] graph = new int[N, N];

            string[] secondRow = Console.ReadLine().Split(' ');

            for (int i = 0; i < M; i++)
            {
                string[] currentStreet = Console.ReadLine().Split(' ');
                int row = int.Parse(currentStreet[0]) - 1;
                int col = int.Parse(currentStreet[1]) - 1;

                graph[row, col] = int.Parse(currentStreet[2]);
            }

            PrintMatrix(graph);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            Console.WriteLine();
            // Print the matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
