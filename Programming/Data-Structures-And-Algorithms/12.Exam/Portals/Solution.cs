namespace Portals
{
    using System;
    using System.Collections.Generic;

    public class Solution
    {
        private static int[,] matrix;
        private static Queue<Cube<int>> queue;
        private static HashSet<Cube<int>> used;

        public static void Main()
        {
            queue = new Queue<Cube<int>>();
            used = new HashSet<Cube<int>>();

            int result = ProcessInput();

            Console.WriteLine(result);
        }

        private static int ProcessInput()
        {
            string[] startPositionStr = Console.ReadLine().Split(' ');
            int x = int.Parse(startPositionStr[0]);
            int y = int.Parse(startPositionStr[1]);
            string[] matrixSizeStr = Console.ReadLine().Split(' ');
            int rows = int.Parse(matrixSizeStr[0]);
            int cols = int.Parse(matrixSizeStr[1]);

            matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int j = 0; j < cols; j++)
                {
                    // # == -1
                    if (line[j] == "#")
                    {
                        matrix[i, j] = -1;
                        used.Add(new Cube<int>(i, j, -1));
                    }
                    else
                    {
                        matrix[i, j] = int.Parse(line[j]);
                    }
                }
            }

            int result = BFS(x, y, rows, cols);
            return result;
        }

        private static int BFS(int x, int y, int rows, int cols)
        {
            // Find
            var startCube = new Cube<int>(x, y, matrix[x, y]);
            queue.Enqueue(startCube);
            used.Add(startCube);

            // int temp = 0;
            int result = 0;

            while (queue.Count > 0)
            {
                int temp = 0;
                var cube = queue.Dequeue();
                int currentPowerNumber = cube.PowerNumber;
                // UP
                if (cube.Row - currentPowerNumber >= 0) // >= !!!
                {
                    var newCube = new Cube<int>(cube.Row - currentPowerNumber, cube.Column, matrix[cube.Row - currentPowerNumber, cube.Column]);
                    if (currentPowerNumber >= temp)
                    {
                        temp = currentPowerNumber;
                    }
                    IsUsed(newCube);
                }

                // Right
                if (cube.Column + currentPowerNumber <= cols - 1)
                {
                    var newCube = new Cube<int>(cube.Row, cube.Column + currentPowerNumber, matrix[cube.Row, cube.Column + currentPowerNumber]);
                    if (currentPowerNumber >= temp)
                    {
                        temp = currentPowerNumber;
                    }
                    IsUsed(newCube);
                }

                // DOWN
                if (cube.Row + currentPowerNumber <= rows - 1)
                {
                    var newCube = new Cube<int>(cube.Row + currentPowerNumber, cube.Column, matrix[cube.Row + currentPowerNumber, cube.Column]);
                    if (currentPowerNumber >= temp)
                    {
                        temp = currentPowerNumber;
                    }
                    IsUsed(newCube);
                }

                // LEFT
                if (cube.Column - currentPowerNumber >= 0)
                {
                    var newCube = new Cube<int>(cube.Row, cube.Column - currentPowerNumber, matrix[cube.Row, cube.Column - currentPowerNumber]);
                    if (currentPowerNumber >= temp)
                    {
                        temp = currentPowerNumber;
                    }
                    IsUsed(newCube);
                }

                result += temp;
            }
            return result;
        }

        private static bool IsUsed(Cube<int> newCube)
        {
            if (!used.Contains(newCube))
            {
                queue.Enqueue(newCube);
                used.Add(newCube);
                return false;
            }

            return true;
        }
    }

    public class Cube<T>
    {
        public Cube(T row, T column, T powerNumber)
        {
            this.Row = row;
            this.Column = column;
            this.PowerNumber = powerNumber;
        }

        public T Row { get; set; }

        public T Column { get; set; }

        public T PowerNumber { get; set; }

        public override bool Equals(object obj)
        {
            var otherCube = obj as Cube<T>;
            if (otherCube == null)
            {
                return false;
            }

            return this.Row.Equals(otherCube.Row) && this.Column.Equals(otherCube.Column);
        }

        public override int GetHashCode()
        {
            return this.Row.GetHashCode() ^ this.Column.GetHashCode() ^ this.PowerNumber.GetHashCode();
        }
    }
}