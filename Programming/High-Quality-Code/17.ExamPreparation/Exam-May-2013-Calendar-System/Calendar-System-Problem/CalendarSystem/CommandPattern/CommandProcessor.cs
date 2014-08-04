namespace CalendarSystem.CommandPattern
{
    using Contracts;
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    public class CommandProcessor : CommandPattern
    {
        private readonly IEventsManager em;

        public CommandProcessor(IEventsManager em)
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

        public override string ProcessCommand(Command command)
        {
            // First command
            if ((command.Name == "AddEvent") && (command.Arguments.Length == 2))
            {
                var date = DateTime.ParseExact(command.Arguments[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
                var e = new Event
                {
                    Date = date,
                    Title = command.Arguments[1],
                    Location = null,
                };

                this.em.AddEvent(e);

                return "Event added";
            }

            if ((command.Name == "AddEvent") && (command.Arguments.Length == 3))
            {
                var date = DateTime.ParseExact(command.Arguments[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
                var e = new Event
                {
                    Date = date,
                    Title = command.Arguments[1],
                    Location = command.Arguments[2],
                };

                this.em.AddEvent(e);

                return "Event added";
            }

            // Second command
            if ((command.Name == "DeleteEvents") && (command.Arguments.Length == 1))
            {
                int c = this.em.DeleteEventsByTitle(command.Arguments[0]);

                if (c == 0)
                {
                    return "No events found";
                }

                return c + " events deleted";
            }

            // Third command
            if ((command.Name == "ListEvents") && (command.Arguments.Length == 2))
            {
                var d = DateTime.ParseExact(command.Arguments[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
                var c = int.Parse(command.Arguments[1]);
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

            throw new Exception("WTF " + command.Name + " is?");
        }
    }
}