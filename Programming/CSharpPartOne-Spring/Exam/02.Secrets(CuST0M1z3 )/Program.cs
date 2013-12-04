using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string number = Console.ReadLine();

        List<int> m = new List<int>();

        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] >= '0' && number[i] <= '9')
            {
                m.Add(number[i] - '0');
            }
        }

        int specialSum = 0;
        int specialSum1 = 0;
        int specialSum2 = 0;

        int j = m.Count;
        int n = 0;

        char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        for (int i = 0; i < m.Count; i++)
        {
            if (j % 2 == 0)
            {
                n = m[i];
                specialSum1 += (n * n) * j;
            }
            else
            {
                n = m[i];
                specialSum2 += n * (j * j);
            }

            j--;
        }

        specialSum = specialSum1 + specialSum2;

        int secretLength = specialSum % 10;

        int r = specialSum % 26;

        int indexOfFirstLetter = r;

        if (indexOfFirstLetter == 26)
        {
            indexOfFirstLetter = 1;
        }

        char firstLetter = letters[indexOfFirstLetter];

        if (secretLength == 0)
        {
            Console.WriteLine(specialSum);
            Console.WriteLine(number + " " + "has no secret alpha-sequence");
        }
        else
        {
            Console.WriteLine(specialSum);

            Console.Write(firstLetter);

            for (int i = 1; i < secretLength; i++)
            {
                int result = indexOfFirstLetter + i;
                if (result >= 26)
                {
                    result = result % 26;
                }

                Console.Write(letters[result]);
            }

            Console.WriteLine();
        }
    }
}