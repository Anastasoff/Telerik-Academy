namespace CalendarSystem
{
    using Contracts;
    using System;

    // TODO: if I don't need the commented code, I can delete it.
    public class Event : IEvent // IComparable<Event>
    {
        public DateTime Date { get; set; }

        public string Title { get; set; }

        public string Location { get; set; }

        public override string ToString()
        {
            string dateFormat = "{0:yyyy-MM-ddTH:mm:ss} | {1}";
            if (this.Location != null)
            {
                dateFormat += " | {2}";
            }

            string formatedEvent = string.Format(dateFormat, this.Date, this.Title, this.Location);

            return formatedEvent;
        }

        //public int CompareTo(Event x)
        //{
        //    int res = DateTime.Compare(this.Date, x.Date);
        //    foreach (char ch in this.Title)
        //    {
        //        if (res == 0)
        //        {
        //            res = string.Compare(this.Title, x.Title, StringComparison.Ordinal);
        //        }

        //        if (res == 0)
        //        {
        //            res = string.Compare(this.Location, x.Location, StringComparison.Ordinal);
        //        }
        //    }

        //    return res;
        //}
    }
}