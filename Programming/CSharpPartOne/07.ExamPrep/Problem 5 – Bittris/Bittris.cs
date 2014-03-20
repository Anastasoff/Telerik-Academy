using System;
using System.Threading;

class Bittris
{
    static void Main()
    {
        int numberOfCommands = int.Parse(Console.ReadLine());

        string[] allInput = new string[numberOfCommands];

        for (int row = 0; row < allInput.Length; row++)
        {
            allInput[row] = Console.ReadLine();
        }

        int inputInteger = 0;
        int[] rows = new int[] { 0, 0, 0, 0 };

        bool isLanded = false;
        int bitsToGet = 8;
        int currentPiece = 0;
        int temp = 0;
        int index = 0;
        int totalScores = 0;

        for (int i = 0; i < allInput.Length; i++)
        {
            //PrintMatrix(rows); // <====
            char inputChar = '\0';
            if (i % 4 == 0)
            {
                //inputInteger = int.Parse(Console.ReadLine());
                inputInteger = int.Parse(allInput[i]);
                currentPiece = GetBits(inputInteger, bitsToGet);
                rows[index] = currentPiece;

                isLanded = false;
            }
            else
            {
                //inputChar = char.Parse(Console.ReadLine());
                inputChar = char.Parse(allInput[i]);
                if (isLanded)
                {
                    continue;
                }
            }

            if (inputChar == 'L')
            {
                temp = rows[index - 1] << 1;
                if (temp < 256)
                {
                    int check = temp & rows[index];
                    if (check == 0) // !!
                    {
                        rows[index] = temp;
                        rows[index - 1] = 0;
                    }
                    else
                    {
                        rows[index - 1] = temp;
                    }
                }
                else
                {
                    inputChar = 'D';
                }

            }
            else if (inputChar == 'R')
            {
                temp = rows[index - 1] >> 1;
                if (temp < 256)
                {
                    int check = temp & rows[index];
                    if (check == 0) // !!
                    {
                        rows[index] |= temp;
                        rows[index - 1] = 0;
                    }
                    else
                    {
                        rows[index - 1] = temp;
                    }
                }
                else
                {
                    inputChar = 'D';
                }

            }

            if (inputChar == 'D')
            {
                int check = rows[index - 1] | rows[index]; // !
                if (check == rows[index - 1] + rows[index])
                {
                    if (check == 255)
                    {
                        isLanded = true;
                        rows[index - 1] = 0;
                        rows[index] = 0;
                        index = 0;
                        totalScores += (CountBits(inputInteger) * 10);
                        continue;
                    }
                    else
                    {
                        rows[index] = rows[index - 1];
                        rows[index - 1] = 0; // !!
                        //rows[index] = check;
                    }
                }
                else
                {
                    index = 0;
                    isLanded = true;
                }
            }

            if (rows[index] == 255)
            {
                isLanded = true;
                rows[index] = 0;
                index = 0;
                totalScores += (CountBits(inputInteger) * 10);
                continue;
            }

            if (index < 3 && !isLanded)
            {
                index++;
            }
            else
            {
                index = 0;

                totalScores += CountBits(inputInteger);
            }
        }

        Console.WriteLine(totalScores);
    }

    /// <summary>
    /// Count how many '1' bits are in the input integer
    /// </summary>
    /// <param name="input"></param>
    /// <returns>count</returns>
    static int CountBits(int input)
    {
        int result = 0;
        int mask = 0;
        int inputAndMask = 0;
        int bit = 0;

        for (int i = 0; i < 32; i++)
        {
            mask = 1 << i;
            inputAndMask = input & mask;
            bit = inputAndMask >> i;
            if (bit == 1)
            {
                result++;
            }
        }

        return result;
    }

    /// <summary>
    /// Get first N bits of an integer number.
    /// </summary>
    /// <param name="inputInteger"></param>
    /// <param name="bitsToGet"></param>
    /// <returns>Integer</returns>
    static int GetBits(int inputInteger, int bitsToGet)
    {
        int result = 0;

        for (int i = 0; i < bitsToGet; i++)
        {
            int mask = 1 << i;
            int inputIntegerAndMask = inputInteger & mask;
            int bit = inputIntegerAndMask >> i;

            mask = bit << i;
            result = result | mask;
        }

        return result;
    }

    static void PrintMatrix(int[] rows)
    {
        Console.Clear();
        for (int i = 0; i < rows.Length; i++)
        {
            Console.WriteLine(Convert.ToString(rows[i], 2).PadLeft(8, '0'));
        }

        Thread.Sleep(1000);
    }
}
