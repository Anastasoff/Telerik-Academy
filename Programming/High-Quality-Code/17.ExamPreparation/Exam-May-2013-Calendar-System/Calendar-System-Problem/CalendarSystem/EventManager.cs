namespace CalendarSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;

    public class EventManager : IEventsManager
    {
        private readonly List<Event> list = new List<Event>();

        public void AddEvent(Event newEvent)
        {
            this.list.Add(newEvent);
        }

        public int DeleteEventsByTitle(string t)
        {
            return this.list.RemoveAll(
                e => e.Title.ToLowerInvariant() == t.ToLowerInvariant());
        }

        public IEnumerable<Event> ListEvents(DateTime d, int c)
        {
            return (from e in this.list
                    where e.D >= d
                    orderby e.D, e.Title, e.Location
                    select e).Take(c);
        }
    }
}