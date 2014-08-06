namespace Computers.Common
{
    using System;
    using System.Threading;

    public class RandomGenerator
    {
        private static Random instance;

        private RandomGenerator()
        {
        }

        /// <summary>
        /// Gets an instance of the Random class, implementation of the Singleton Design Pattern
        /// </summary>
        public static Random GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Random(unchecked((Environment.TickCount * 31) + Thread.CurrentThread.ManagedThreadId));
                }

                return instance;
            }
        }
    }
}