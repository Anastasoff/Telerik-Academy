namespace CalendarSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EM : IEventsManager
    {
        private readonly List<Ev> list = new List<Ev>();

        public void AddEvent(Ev e)
        {
            this.list.Add(e);
        }

        public int DeleteEventsByTitle(string t)
        {
            return this.list.RemoveAll(
                e => e.Title.ToLowerInvariant() == t.ToLowerInvariant());
        }

        public IEnumerable<Ev> ListEvents(DateTime d, int c)
        {
            return (from e in this.list
                    where e.D >= d
                    orderby e.D, e.Title, e.Location
                    select e).Take(c);
        }
    }
}