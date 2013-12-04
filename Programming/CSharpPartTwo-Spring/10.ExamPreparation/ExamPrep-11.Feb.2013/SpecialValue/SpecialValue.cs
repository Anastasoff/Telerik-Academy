using System;

class SpecialValue
{
    static void Main()
    {
        // input
        int numberOfRows = int.Parse(Console.ReadLine());

        int[][] numbers = new int[numberOfRows][];
        for (int row = 0; row < numberOfRows; row++)
        {
            string[] numberStr = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            numbers[row] = new int[numberStr.Length];
            for (int col = 0; col < numberStr.Length; col++)
            {
                numbers[row][col] = int.Parse(numberStr[col]);
            }
        }

        bool[][] used = new bool[numbers.Length][];
        for (int row = 0; row < used.Length; row++)
        {
            used[row] = new bool[numbers[row].Length];
        }

        // solution
        int maxSpecialValue = int.MinValue;
        for (int col = 0; col < numbers[0].Length; col++)
        {
            int currentValue = GetValue(col, numbers, used);
            if (maxSpecialValue < currentValue)
            {
                maxSpecialValue = currentValue;
            }
        }

        Console.WriteLine(maxSpecialValue);
    }

    private static int GetValue(int startColumn, int[][] numbers, bool[][] used)
    {
        for (int i = 0; i < used.Length; i++)
        {
            used[i] = new bool[numbers[i].Length];
        }

        int row = 0;
        int col = startColumn;
        int path = 0;
        while (col >= 0 && !used[row][col])
        {
            used[row][col] = true;
            path++;
            col = numbers[row][col];
            row++;
            if (row >= numbers.Length)
            {
                row = row - numbers.Length;
            }
        }

        if (col < 0)
        {
            int value = path + (-col);

            return value;
        }
        else
        {
            return -1;
        }
    }
}
