namespace ExecuteAtTime
{
    using System;
    using System.Threading;

    public class Timer
    {
        public int T { get; set; }

        public Timer(Action action, int t)
        {
            this.T = t;
            Thread start = new Thread(() =>
            {
                while (true)
                {
                    action();
                    Thread.Sleep(this.T * 1000);
                }
            });
            start.Start();
        }        
    }
}
