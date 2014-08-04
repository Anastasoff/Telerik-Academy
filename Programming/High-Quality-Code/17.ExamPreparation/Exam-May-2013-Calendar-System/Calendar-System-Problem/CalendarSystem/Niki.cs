namespace CalendarSystem
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using Contracts;

    public class Niki
    {
        private readonly IEventsManager em;

        public Niki(IEventsManager em)
        {
            this.em = em;
        }

        public IEventsManager EventsProcessor
        {
            get
            {
                return this.em;
            }
        }

        public string ProcessCommand(Command com)
        {
            // First command
            if ((com.Name == "AddEvent") && (com.Arguments.Length == 2))
            {
                var date = DateTime.ParseExact(com.Arguments[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
                var e = new Event
                {
                    Date = date,
                    Title = com.Arguments[1],
                    Location = null,
                };

                this.em.AddEvent(e);

                return "Event added";
            }

            if ((com.Name == "AddEvent") && (com.Arguments.Length == 3))
            {
                var date = DateTime.ParseExact(com.Arguments[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
                var e = new Event
                {
                    Date = date,
                    Title = com.Arguments[1],
                    Location = com.Arguments[2],
                };

                this.em.AddEvent(e);

                return "Event added";
            }

            // Second command
            if ((com.Name == "DeleteEvents") && (com.Arguments.Length == 1))
            {
                int c = this.em.DeleteEventsByTitle(com.Arguments[0]);

                if (c == 0)
                {
                    return "No events found";
                }

                return c + " events deleted";
            }

            // Third command
            if ((com.Name == "ListEvents") && (com.Arguments.Length == 2))
            {
                var d = DateTime.ParseExact(com.Arguments[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
                var c = int.Parse(com.Arguments[1]);
                var events = this.em.ListEvents(d, c).ToList();
                var sb = new StringBuilder();

                if (!events.Any())
                {
                    return "No events found";
                }

                foreach (var e in events)
                {
                    sb.AppendLine(e.ToString());
                }

                return sb.ToString().Trim();
            }

            throw new Exception("WTF " + com.Name + " is?");
        }
    }
}