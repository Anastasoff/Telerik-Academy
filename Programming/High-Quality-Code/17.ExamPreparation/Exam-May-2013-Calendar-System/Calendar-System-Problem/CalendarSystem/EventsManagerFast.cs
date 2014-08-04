namespace CalendarSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;
    using MD = Wintellect.PowerCollections.MultiDictionary<string, CalendarSystem.Event>;
    using Contracts;

    public class EventsManagerFast : IEventsManager
    {
        private readonly MD t = new MD(true);
        private readonly OrderedMultiDictionary<DateTime, Event> a = new OrderedMultiDictionary<DateTime, Event>(true);

        public void AddEvent(Event e)
        {
            string eventTitleLowerCase = e.Title.ToLowerInvariant();
            this.t.Add(eventTitleLowerCase, e);
            this.a.Add(e.Date, e);
        }

        public int DeleteEventsByTitle(string t)
        {
            string lc = t.ToLowerInvariant();
            var del = this.t[lc];
            int countx = del.Count;

            foreach (var e in del)
            {
                this.a.Remove(e.Date, e);
            }

            this.t.Remove(lc);

            return countx;
        }

        public IEnumerable<Event> ListEvents(DateTime d, int c)
        {
            var da =
                from e in this.a.RangeFrom(d, true).Values
                select e;
            var events = da.Take(c);
            return events;
        }
    }
}