namespace BullsAndCows.Game.Logic
{
    using System;

    public class RandomGenerator
    {
        private static Random instance;

        private RandomGenerator()
        {
        }

        public static Random GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Random();
                }
                return instance;
            }
        }
    }
}