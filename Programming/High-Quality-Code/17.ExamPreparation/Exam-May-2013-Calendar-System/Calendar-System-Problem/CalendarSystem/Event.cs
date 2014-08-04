namespace CalendarSystem
{
    using Contracts;
    using System;

    // TODO: if I don't need the commented code, I can delete it.
    public class Event : IEvent, IComparable<Event>
    {
        public DateTime Date { get; set; }

        public string Title { get; set; }

        public string Location { get; set; }

        public override string ToString()
        {
            string dateFormat = "{0:yyyy-MM-ddTHH:mm:ss} | {1}";
            if (this.Location != null)
            {
                dateFormat += " | {2}";
            }

            string formatedEvent = string.Format(dateFormat, this.Date, this.Title, this.Location);

            return formatedEvent;
        }

        public int CompareTo(Event other)
        {
            int result = DateTime.Compare(this.Date, other.Date);

            if (result == 0)
            {
                result = string.Compare(this.Title, other.Title, StringComparison.Ordinal);
            }

            if (result == 0)
            {
                result = string.Compare(this.Location, other.Location, StringComparison.Ordinal);
            }

            return result;
        }
    }
}