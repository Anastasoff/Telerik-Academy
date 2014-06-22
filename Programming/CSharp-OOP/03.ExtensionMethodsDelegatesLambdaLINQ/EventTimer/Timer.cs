namespace EventTimer
{
    using System;
    using System.Threading;

    public class Timer
    {
        private EventArgs e = null;

        public delegate void TimerEventHandler(Timer counter, EventArgs e);

        public event TimerEventHandler Act;        

        public void Start(int seconds)
        {
            while (true)
            {
                if (this.Act != null)
                {
                    this.Act(this, this.e);
                }

                Thread.Sleep(seconds * 1000);
            }
        }
    }
}
