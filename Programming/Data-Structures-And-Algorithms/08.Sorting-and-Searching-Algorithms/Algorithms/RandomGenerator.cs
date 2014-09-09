namespace Algorithms
{
    using System;
    using System.Threading;

    /// <summary>
    /// Thread safe random generator
    /// </summary>
    public class RandomGenerator
    {
        [ThreadStatic]
        private static Random instance;

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