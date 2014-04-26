using System;
using System.Text;
using System.Numerics;

class TheSecretsofNumbers
{
    static void Main()
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        BigInteger cw = number;
        if (number < 0)
        {
            number *= -1;
        }
        int counter = 1;
        BigInteger sum = 0;

        while (number > 0)
        {
            BigInteger temp = number % 10;
            number /= 10;

            if (counter % 2 != 0) // odd
            {
                sum += temp * (BigInteger)Math.Pow(counter, 2);
            }
            else // even
            {
                sum += (BigInteger)Math.Pow((int)temp, 2) * counter;
            }

            counter++;
        }

        Console.WriteLine(sum);

        BigInteger length = sum % 10;
        if (length == 0)
        {
            Console.WriteLine("{0} has no secret alpha-sequence", cw);
        }
        else
        {
            BigInteger r = sum % 26;
            int ch = 64;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                char alphabet = (char)(ch + (r + 1));
                sb.Append(alphabet.ToString());
                ch++;
                if (ch + (r + 1) > 90)
                {
                    r = 0;
                    ch = 64;
                }
            }


            Console.WriteLine(sb.ToString());
        }
    }
}
