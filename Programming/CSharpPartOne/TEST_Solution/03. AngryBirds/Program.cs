using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AngryBits
{
    static void Main()
    {
        ushort[,] m = new ushort[8, 16];


        for (int row = 0; row < 8; row++)
        {
            ushort bits = ushort.Parse(Console.ReadLine());
            for (int col = 0; col < 16; col++)
            {
                if ((bits & (1 << col)) != 0)
                {
                    m[row, col] = 1;
                }

            }
        }
        ushort pigCount = 0;
        ushort finalResult = 0;
        ushort result = 0;
        ushort count = 0;
        int startRow = 0;
        int startCol = 0;

        int pig = 0;
        for (int pigRow = 0; pigRow < 8; pigRow++)
        {
            for (int pigCol = 0; pigCol < 8; pigCol++)
            {
                if (m[pigRow, pigCol] == 1)
                {
                    pig++;
                }
            }
        }

        for (int col = 8; col < 16; col++)
        {
            count = 0;
            result = 0;
            pigCount = 0;
            for (int row = 0; row < 8; row++)
            {
                if (m[row, col] == 1)
                {
                    startRow = row;
                    startCol = col;
                    m[row, col] = 0;
                    if (row > 0)
                    {
                        row--;
                        col--;
                        while (row > 0 && m[row, col] == 0)
                        {
                            count++;
                            row--;
                            col--;
                        }
                        if (row == 0 && m[row, col] == 0)
                        {
                            count++;
                        }
                        if (m[row, col] == 1)
                        {
                            count++;
                            pigCount++;
                            m[row, col] = 0;
                            if (m[row + 1, col] == 1)
                            {
                                pigCount++;
                                m[row + 1, col] = 0;
                            }
                            if (row > 0 && m[row - 1, col] == 1)
                            {
                                pigCount++;
                                m[row - 1, col] = 0;
                            }
                            if (m[row + 1, col + 1] == 1)
                            {
                                pigCount++;
                                m[row + 1, col + 1] = 0;
                            }
                            if (m[row + 1, col - 1] == 1)
                            {
                                pigCount++;
                                m[row + 1, col - 1] = 0;
                            }
                            if (row > 0 && m[row - 1, col + 1] == 1)
                            {
                                pigCount++;
                                m[row - 1, col + 1] = 0;
                            }
                            if (row > 0 && m[row - 1, col - 1] == 1)
                            {
                                pigCount++;
                                m[row - 1, col - 1] = 0;
                            }
                            if (m[row, col + 1] == 1)
                            {
                                pigCount++;
                                m[row, col + 1] = 0;
                            }
                            if (m[row, col - 1] == 1)
                            {
                                pigCount++;
                                m[row, col - 1] = 0;
                            }
                            result += (ushort)(count * pigCount);
                            pig -= pigCount;
                            finalResult += result;
                        }
                    }
                    if (result > 0)
                    {
                        col = startCol;
                        break;
                    }
                    if (row == 0)
                    {
                        row++;
                        col--;
                        while (row < 7 && col > 0 && m[row, col] == 0)
                        {
                            count++;
                            row++;
                            col--;
                        }
                        if (((row == 7) || (col == 0)) && m[row, col] == 0)
                        {
                            count = 0;
                        }
                        if (m[row, col] == 1)
                        {
                            count++;
                            pigCount++;
                            m[row, col] = 0;
                            if (row < 7 && m[row + 1, col] == 1)
                            {
                                pigCount++;
                                m[row + 1, col] = 0;
                            }
                            if (m[row - 1, col] == 1)
                            {
                                pigCount++;
                                m[row - 1, col] = 0;
                            }
                            if (row < 7 && m[row + 1, col + 1] == 1)
                            {
                                pigCount++;
                                m[row + 1, col + 1] = 0;
                            }
                            if (row < 7 && col > 0 && m[row + 1, col - 1] == 1)
                            {
                                pigCount++;
                                m[row + 1, col - 1] = 0;
                            }
                            if (m[row - 1, col + 1] == 1)
                            {
                                pigCount++;
                                m[row - 1, col + 1] = 0;
                            }
                            if (col > 0 && m[row - 1, col - 1] == 1)
                            {
                                pigCount++;
                                m[row - 1, col - 1] = 0;
                            }
                            if (m[row, col + 1] == 1)
                            {
                                pigCount++;
                                m[row, col + 1] = 0;
                            }
                            if (col > 0 && m[row, col - 1] == 1)
                            {
                                pigCount++;
                                m[row, col - 1] = 0;
                            }
                            result += (ushort)(count * pigCount);
                            pig -= pigCount;
                            finalResult += result;
                        }
                    }
                    col = startCol;
                    break;
                }
            }
        }
        if (pig == 0)
        {
            Console.WriteLine(finalResult + " " + "Yes");
        }
        else
        {
            Console.WriteLine(finalResult + " " + "No");
        }

    }
}
