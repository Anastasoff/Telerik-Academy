namespace CalendarSystem.Contracts
{
    using System;

    public interface IEvent
    {
        DateTime Date { get; set; }

        string Title { get; set; }

        string Location { get; set; }
    }
}