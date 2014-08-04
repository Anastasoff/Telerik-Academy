using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;
using MD = Wintellect.PowerCollections.MultiDictionary<string, CalendarSystem.Ev>;

namespace CalendarSystem
{
    public class EventsManagerFast : IEventsManager
    {
        private readonly MD t = new MD(true);
        private readonly OrderedMultiDictionary<DateTime, Ev> a = new OrderedMultiDictionary<DateTime, Ev>(true);

        public void AddEvent(Ev e)
        {
            string eventTitleLowerCase = e.Title.ToLowerInvariant();
            this.t.Add(eventTitleLowerCase, e);
            this.a.Add(e.d, e);
        }

        public int DeleteEventsByTitle(string t)
        {
            string lc = t.ToLowerInvariant();
            var del = this.t[lc];
            int countx = del.Count;

            foreach (var e in del)
            {
                this.a.Remove(e.d, e);
            }

            this.t.Remove(lc);

            return countx;
        }

        public IEnumerable<Ev> ListEvents(DateTime d, int c)
        {
            var da =
                from e in this.a.RangeFrom(d, true).Values
                select e;
            var events = da.Take(c);
            return events;
        }
    }
}
