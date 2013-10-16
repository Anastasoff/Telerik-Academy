namespace EventTimer
{
    using System;

    public class Subscriber
    {
        public void Subscribe(Timer start)
        {
            start.Act += new Timer.EventHandler(this.ExecuteMe);
        }

        public void ExecuteMe(Timer timer, EventArgs e)
        {
            Console.WriteLine("Execute me at: {0}", DateTime.Now);
        }
    }
}
