// 8. * Read in MSDN about the keyword event in C# and how to publish events.
//      Re-implement the above using .NET events and following the best practices.

namespace EventTimer
{
    public class EventTimer
    {
        public static void Main()
        {
            Timer start = new Timer();
            Subscriber sub = new Subscriber();

            int t = 1; // seconds
            sub.Subscribe(start);
            start.Start(t);
        }
    }
}
