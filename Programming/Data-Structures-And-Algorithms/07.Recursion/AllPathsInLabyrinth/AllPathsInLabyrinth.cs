// 7. We are given a matrix of passable and non-passable cells.
//  Write a recursive program for finding all paths between two cells in the matrix.
namespace AllPathsInLabyrinth
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class AllPathsInLabyrinth
    {
        private static char[,] matrix =
        {
            {' ', ' ', ' ', '#', ' ', ' ', ' ' },
            {'#', '#', ' ', '#', ' ', '#', ' ' },
            {' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            {' ', '#', '#', '#', '#', '#', ' ' },
            {' ', ' ', ' ', ' ', ' ', ' ', 'e' }
        };

        private static IList<char> path = new List<char>();
        private static int exitCounter = 1;
        private const int StartRow = 0;
        private const int StartColumn = 0;
        private const char StartDirection = 'S';
        private const char Up = 'U';
        private const char Right = 'R';
        private const char Down = 'D';
        private const char Left = 'L';
        private const char Exit = 'e';
        private const char VisitedCell = 'x';
        private const char PassableCell = ' ';

        public static void Main()
        {
            FindAllPaths(StartRow, StartColumn, StartDirection);
        }

        private static void FindAllPaths(int row, int col, char direction)
        {
            bool isOutOfMatrix =
                (col < 0) || (row < 0) ||
                (col >= matrix.GetLength(1)) ||
                (row >= matrix.GetLength(0));

            if (isOutOfMatrix)
            {
                return;
            }
            else if (matrix[row, col] == Exit)
            {
                PrintPaths();
            }
            else if (matrix[row, col] != PassableCell)
            {
                return;
            }
            else
            {
                path.Add(direction);
                matrix[row, col] = VisitedCell;

                FindAllPaths(row - 1, col, Up);
                FindAllPaths(row, col + 1, Right);
                FindAllPaths(row + 1, col, Down);
                FindAllPaths(row, col - 1, Left);

                path.RemoveAt(path.Count - 1);
                matrix[row, col] = PassableCell;
            }
        }

        private static void PrintPaths()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Exit #" + exitCounter++);

            sb.Append("Start-");
            for (int i = 1; i < path.Count; i++)
            {
                sb.Append(path[i] + "-");
            }

            sb.AppendLine("Exit");
            Console.WriteLine(sb);
        }
    }
}