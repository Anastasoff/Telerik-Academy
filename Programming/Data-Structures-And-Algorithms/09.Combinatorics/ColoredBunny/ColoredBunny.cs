namespace ColoredBunny
{
    using System;
    using System.Collections.Generic;

    public class ColoredBunny
    {
        public static void Main()
        {
            Dictionary<int, int> bunnies = new Dictionary<int, int>();
            int numberOfBunnies = int.Parse(Console.ReadLine());
            long result = 0;

            for (int i = 0; i < numberOfBunnies; i++)
            {
                int answer = int.Parse(Console.ReadLine()) + 1;
                if (!bunnies.ContainsKey(answer))
                {
                    bunnies[answer] = 0;
                }

                bunnies[answer]++;
            }

            foreach (var bunny in bunnies)
            {
                result += (bunny.Key + bunny.Value - 1) / bunny.Key * bunny.Key;
            }

            Console.WriteLine(result);
        }
    }
}