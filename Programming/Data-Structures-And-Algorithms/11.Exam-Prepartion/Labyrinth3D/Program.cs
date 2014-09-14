namespace Labyrinth3D
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        private static HashSet<Cell<int>> used;
        private static Queue<Cell<int>> queue;

        public static void Main()
        {
            used = new HashSet<Cell<int>>();
            queue = new Queue<Cell<int>>();

            ProcessInput();
        }

        private static void ProcessInput()
        {
            string[] startPosition = Console.ReadLine().Split(' ');
            int startX = int.Parse(startPosition[0]);
            int startY = int.Parse(startPosition[1]);
            int startZ = int.Parse(startPosition[2]);
            var startCell = new Cell<int>(startX, startY, startZ, 0);

            string[] dimenstions = Console.ReadLine().Split(' ');
            int level = int.Parse(dimenstions[0]);
            int row = int.Parse(dimenstions[1]);
            int col = int.Parse(dimenstions[2]);

            var labyrinth = new char[level, row, col];
            for (int x = 0; x < level; x++)
            {
                for (int y = 0; y < row; y++)
                {
                    string line = Console.ReadLine();
                    for (int z = 0; z < col; z++)
                    {
                        labyrinth[x, y, z] = line[z];
                        if (labyrinth[x, y, z] == '#')
                        {
                            used.Add(new Cell<int>(x, y, z, -1));
                        }
                    }
                }
            }

            int numberOfMoves = FindExitWithBFS(startCell, level, row, col, labyrinth);

            Console.WriteLine(numberOfMoves);
        }

        private static int FindExitWithBFS(Cell<int> startCell, int l, int r, int c, char[, ,] labyrinth)
        {
            queue.Enqueue(startCell);
            used.Add(startCell);
            int numberOfMoves = 0;
            while (queue.Count > 0)
            {
                var cell = queue.Dequeue();

                // Left
                if (cell.Column > 0)
                {
                    var newCell = new Cell<int>(cell.Level, cell.Row, cell.Column - 1, cell.QueueLevel + 1);
                    IsUsed(newCell);
                }

                // Right
                if (cell.Column < c - 1)
                {
                    var newCell = new Cell<int>(cell.Level, cell.Row, cell.Column + 1, cell.QueueLevel + 1);
                    IsUsed(newCell);
                }

                // Back
                if (cell.Row > 0)
                {
                    var newCell = new Cell<int>(cell.Level, cell.Row - 1, cell.Column, cell.QueueLevel + 1);
                    IsUsed(newCell);
                }

                // Forward
                if (cell.Row < r - 1)
                {
                    var newCell = new Cell<int>(cell.Level, cell.Row + 1, cell.Column, cell.QueueLevel + 1);
                    IsUsed(newCell);
                }

                // Up
                if (labyrinth[cell.Level, cell.Row, cell.Column] == 'U')
                {
                    if (cell.Level == l - 1)
                    {
                        numberOfMoves = cell.QueueLevel + 1;
                        break;
                    }
                    else
                    {
                        var newCell = new Cell<int>(cell.Level + 1, cell.Row, cell.Column, cell.QueueLevel + 1);
                        IsUsed(newCell);
                    }
                }

                // Down
                if (labyrinth[cell.Level, cell.Row, cell.Column] == 'D')
                {
                    if (cell.Level == 0)
                    {
                        numberOfMoves = cell.QueueLevel + 1;
                        break;
                    }
                    else
                    {
                        var newCell = new Cell<int>(cell.Level - 1, cell.Row, cell.Column, cell.QueueLevel + 1);
                        IsUsed(newCell);
                    }
                }
            }

            return numberOfMoves;
        }

        private static void IsUsed(Cell<int> newCell)
        {
            if (!used.Contains(newCell))
            {
                queue.Enqueue(newCell);
                used.Add(newCell);
            }
        }
    }

    public class Cell<T>
    {
        public Cell(T level, T row, T column, int queueLevel)
        {
            this.Level = level;
            this.Row = row;
            this.Column = column;
            this.QueueLevel = queueLevel;
        }

        public T Level { get; set; }

        public T Row { get; set; }

        public T Column { get; set; }

        public int QueueLevel { get; set; }

        public override bool Equals(object obj)
        {
            var otherCell = obj as Cell<T>;
            if (otherCell == null)
            {
                return false;
            }

            return this.Level.Equals(otherCell.Level)
                && this.Row.Equals(otherCell.Row)
                && this.Column.Equals(otherCell.Column);
        }

        public override int GetHashCode()
        {
            return this.Level.GetHashCode()
                ^ this.Row.GetHashCode()
                ^ this.Column.GetHashCode();
        }
    }
}