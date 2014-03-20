/*
5. Write a program that reads a text file containing a square matrix of numbers 
    and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. 
    The first line in the input file contains the size of matrix N. 
    Each of the next N lines contain N numbers separated by space. 
    The output should be a single number in a separate text file. 
Example:

4
2 3 3 4
0 2 3 4   ---> 17
3 7 1 2
4 3 3 2
*/

using System;
using System.IO;

class FindMaxSumInMatrix
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\matrix.txt"))
        {
            string matrixSize = reader.ReadLine();
            int size = int.Parse(matrixSize);
            string[] arr = new string[size];

            string readLine = reader.ReadLine();
            int counter = 0;
            while (readLine != null)
            {
                arr[counter] = readLine;
                counter++;
                readLine = reader.ReadLine();
            }

            int[,] matrix = new int[size, size];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] values = arr[row].Split(' ');
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(values[col]);
                }
            }

            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter(@"..\..\output.txt"))
            {
                writer.WriteLine(bestSum);
            }

            Console.WriteLine("Maximum sum is: {0}", bestSum);
            Console.WriteLine("File is written!");
        }
    }
}
