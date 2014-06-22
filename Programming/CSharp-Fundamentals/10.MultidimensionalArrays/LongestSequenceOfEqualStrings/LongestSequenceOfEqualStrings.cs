// 3. We are given a matrix of strings of size N x M. 
//    Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. 
//    Write a program that finds the longest sequence of equal strings in the matrix. 

using System;

class LongestSequenceOfEqualStrings
{
    static void Main()
    {
        //input
        string[,] matrix =
        {
            { "ha", "fifi", "ho", "hi" },
            { "fo", "ha", "hi", "xx" },
            { "xxx", "ho", "ha", "xx" }
        };

        //string[,] matrix =
        //{
        //    { "s", "qq", "s" },
        //    { "pp", "pp", "s" },
        //    { "pp", "qq", "s" }
        //};

        int matrixRowsLength = matrix.GetLength(0);
        int matrixColsLength = matrix.GetLength(1);

        int currentSeq = 1;
        int maxSeq = 0;
        string maxElement = string.Empty;
        int bestSeqRow = 0;
        int bestSeqCol = 0;
        int direction = 0;

        // horizontal
        for (int row = 0; row < matrixRowsLength; row++)
        {
            for (int col = 0; col < matrixColsLength - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    currentSeq++;
                }
                else
                {
                    currentSeq = 1;
                }

                if (maxSeq < currentSeq)
                {
                    maxSeq = currentSeq;
                    maxElement = matrix[row, col];
                    bestSeqRow = row;
                    bestSeqCol = col + 1;
                    direction = 1;
                }
            }

            currentSeq = 1;
        }

        // vertical
        for (int col = 0; col < matrixColsLength; col++)
        {
            for (int row = 0; row < matrixRowsLength - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    currentSeq++;
                }
                else
                {
                    currentSeq = 1;
                }

                if (maxSeq < currentSeq)
                {
                    maxSeq = currentSeq;
                    maxElement = matrix[row, col];
                    bestSeqCol = col;
                    bestSeqRow = row + 1;
                    direction = 2;
                }
            }

            currentSeq = 1;
        }

        // diagonal
        for (int row = 0; row < matrixRowsLength - 1; row++)
        {
            for (int col = 0; col < matrixColsLength - 1; col++)
            {
                for (int rows = row, cols = col; rows < matrixRowsLength - 1 && cols < matrixColsLength - 1; rows++, cols++)
                {
                    if (matrix[rows, cols] == matrix[rows + 1, cols + 1])
                    {
                        currentSeq++;
                    }
                    else
                    {
                        currentSeq = 1;
                    }

                    if (maxSeq < currentSeq)
                    {
                        maxSeq = currentSeq;
                        maxElement = matrix[rows, cols];
                        bestSeqRow = rows + 1;
                        bestSeqCol = cols + 1;
                        direction = 3;
                    }
                }

                currentSeq = 1;
            }
        }

        // diagonal
        for (int row = 0; row < matrixRowsLength - 1; row++)
        {
            for (int col = 1; col < matrixColsLength; col++)
            {
                for (int rows = row, cols = col; rows < matrixRowsLength - 1 && cols > 0; rows++, cols--)
                {
                    if (matrix[rows, cols] == matrix[rows + 1, cols - 1])
                    {
                        currentSeq++;
                    }
                    else
                    {
                        currentSeq = 1;
                    }

                    if (maxSeq < currentSeq)
                    {
                        maxSeq = currentSeq;
                        maxElement = matrix[rows, cols];
                        bestSeqRow = rows + 1;
                        bestSeqCol = cols - 1;
                        direction = 4;
                    }
                }

                currentSeq = 1;
            }
        }

        bool[,] used = new bool[matrixRowsLength, matrixColsLength];

        switch (direction)
        {
            case 1:
                for (int i = bestSeqCol; i >= Math.Abs(maxSeq - bestSeqCol - 1); i--)
                {
                    used[bestSeqRow, i] = true;
                }

                break;
            case 2:
                for (int i = bestSeqRow; i >= Math.Abs(maxSeq - bestSeqRow - 1); i--)
                {
                    used[i, bestSeqCol] = true;
                }

                break;
            case 3:
                for (int row = bestSeqRow, col = bestSeqCol; row >= Math.Abs(maxSeq - bestSeqRow - 1) && col >= Math.Abs(maxSeq - bestSeqCol - 1); row--, col--)
                {
                    used[row, col] = true;
                }

                break;
            case 4:
                for (int row = bestSeqRow, col = bestSeqCol; row >= Math.Abs(maxSeq - bestSeqRow - 1); row--, col++)
                {
                    used[row, col] = true;
                }

                break;
            default:
                break;
        }

        // printing the matrix and colored the longest sequence in red
        PrintMatrix(matrix, matrixRowsLength, matrixColsLength, used, maxSeq, maxElement);
    }

    private static void PrintSequence(int maxSeq, string maxElement)
    {
        Console.Write(" ---> ");
        Console.ForegroundColor = ConsoleColor.Red;
        for (int i = 0; i < maxSeq; i++)
        {
            Console.Write(maxElement);
            if (i != maxSeq - 1)
            {
                Console.Write(", ");
            }
        }

        Console.ResetColor();
    }

    private static void PrintMatrix(string[,] matrix, int matrixRowsLength, int matrixColsLength, bool[,] used, int maxSeq, string maxElement)
    {
        int mid = matrixRowsLength / 2;
        for (int row = 0; row < matrixRowsLength; row++)
        {
            for (int col = 0; col < matrixColsLength; col++)
            {
                if (used[row, col] == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("{0, 4} ", matrix[row, col]);
                    Console.ResetColor();
                }
                else
                {
                    Console.Write("{0, 4} ", matrix[row, col]);
                }
            }

            if (mid == row)
            {
                PrintSequence(maxSeq, maxElement);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}