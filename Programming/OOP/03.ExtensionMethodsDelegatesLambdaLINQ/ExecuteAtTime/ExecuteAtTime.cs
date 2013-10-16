// 7. Using delegates write a class Timer that has can execute certain method at each t seconds.

namespace ExecuteAtTime
{
    using System;
    using System.Threading;

    public class ExecuteAtTime
    {
        public static void ExecuteMe()
        {
            Console.WriteLine("Execute me at: {0}", DateTime.Now);
        }

        public static void Main()
        {
            int t = 1; // seconds
            Timer start = new Timer(() => ExecuteMe(), t);
        }
    }
}
