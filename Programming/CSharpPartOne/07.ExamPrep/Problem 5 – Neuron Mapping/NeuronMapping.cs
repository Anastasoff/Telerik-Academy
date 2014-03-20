using System;
using System.Text;

class NeuronMapping
{
    static void Main()
    {
        StringBuilder result = new StringBuilder();
        const uint BIT = 1U;

        while (true)
        {
            string inputIntegerAsString = Console.ReadLine();
            if (inputIntegerAsString == "-1")
            {
                break;
            }

            uint inputInteger = uint.Parse(inputIntegerAsString);
            uint outputInteger = 0;
            bool isInside = false;
            int singleBits = 0;

            for (int position = 0; position < 32; ++position)
            {
                uint mask = BIT << position;

                if ((inputInteger & mask) == 0)
                {
                    if (isInside)
                    {
                        outputInteger |= mask;
                    }
                }
                else
                {
                    while (position < 32 && (inputInteger & (BIT << position)) != 0)
                    {
                        position++;
                    }

                    position--;
                    singleBits++;
                    isInside = !isInside;
                }
            }

            if (singleBits != 2)
            {
                outputInteger = 0;
            }

            result.AppendLine(outputInteger.ToString());
        }

        Console.Write(result);
    }
}
