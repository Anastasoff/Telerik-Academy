using System;

class JoroTheRabbit
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[input.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = (int.Parse(input[i]));
        }

        int bestLength = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 1; j < numbers.Length; j++)
            {
                int currentPosition = i;
                int stepLength = 1;

                // nextPosition = (currentPosition + j) % numbers.Length;
                int nextPosition = currentPosition + j;
                if (nextPosition >= numbers.Length)
                {
                    nextPosition = nextPosition - numbers.Length;
                }

                while (numbers[currentPosition] < numbers[nextPosition])
                {
                    currentPosition = nextPosition;
                    stepLength++;

                    // nextPosition = (currentPosition + j) % numbers.Length;
                    nextPosition = currentPosition + j;
                    if (nextPosition >= numbers.Length)
                    {
                        nextPosition = nextPosition - numbers.Length;
                    }
                }

                if (bestLength < stepLength)
                {
                    bestLength = stepLength;
                }
            }
        }

        Console.WriteLine(bestLength);
    }
}