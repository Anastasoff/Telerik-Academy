namespace CalendarSystem.Contracts
{
    using System;
    using System.Collections.Generic;

    public interface IEventsManager
    {
        void AddEvent(Event newEvent);

        int DeleteEventsByTitle(string title);

        IEnumerable<Event> ListEvents(DateTime date, int count);
    }
}