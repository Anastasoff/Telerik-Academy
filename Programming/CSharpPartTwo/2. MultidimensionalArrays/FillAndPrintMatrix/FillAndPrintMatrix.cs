// 1. Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

using System;

class FillAndPrintMatrix
{
    // a)
    static void MatrixA(int[,] matrix, int size, int counter)
    {
        for (int col = 0; col < size; col++)
        {
            for (int row = 0; row < size; row++)
            {
                matrix[row, col] = counter++; 
            }
        }

        PrintMatrix(matrix, size);
    }

    // b)
    static void MatrixB(int[,] matrix, int size, int counter)
    {
        for (int col = 0; col < size; col++)
        {
            if ((col % 2) == 0) // if the "col" index is even, filling the matrix from top to bottom;
            {
                for (int row = 0; row < size; row++)
                {
                    matrix[row, col] = counter++;
                }
            }
            else // if the "col" index is odd, filling the matrix from bottom to top;
            {
                for (int row = size - 1; row >= 0; row--)
                {
                    matrix[row, col] = counter++;
                }
            }
        }

        PrintMatrix(matrix, size);
    }

    // c)
    static void MatrixC(int[,] matrix, int size, int counter)
    {
        for (int row = size - 1; row >= 0; row--)
        {
            for (int col = 0; col < size - row; col++)
            {
                matrix[row + col, col] = counter++;
            }
        }

        for (int col = 1; col < size; col++)
        {
            for (int row = 0; row < size - col; row++)
            {
                matrix[row, col + row] = counter++;
            }
        }

        PrintMatrix(matrix, size);
    }

    // d)
    static void MatrixD(int[,] matrix, int size, int counter)
    {
        for (int index = 0; index <= size / 2; index++)
        {
            // direction: down
            for (int row = index; row < size - index; row++)
            {
                matrix[row, index] = counter++;
            }

            // direction: right
            for (int col = index; col < size - index; col++)
            {
                matrix[size - index, col] = counter++;
            }

            // direction: up
            for (int row = size - index; row > index; row--)
            {
                matrix[row, size - index] = counter++;
            }

            // direction: left
            for (int col = size - index; col > index; col--)
            {
                matrix[index, col] = counter++;
            }
        }

        if ((size % 2) == 0)
        {
            matrix[size / 2, size / 2] = counter;
        }

        PrintMatrix(matrix, size + 1);
    }

    static void PrintMatrix(int[,] matrix, int size)
    {
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                Console.Write("{0,6}", matrix[row, col]);
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        Console.WriteLine(new string('-', size * 6));
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter n = ");
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];
        int counter = 1;

        Console.WriteLine(new string('=', size * 6));
        Console.WriteLine();

        MatrixA(matrix, size, counter);
        MatrixB(matrix, size, counter);
        MatrixC(matrix, size, counter);
        MatrixD(matrix, size - counter, counter);
    }
}
