namespace CalendarSystem
{
    using System;

    public class Ev : IComparable<Ev>
    {
        public string Title { get; set; }

        public string Location { get; set; }

        public DateTime D { get; set; }

        public override string ToString()
        {
            string form = "{0:yyyy-MM-ddTH:mm:ss} | {1}";
            if (this.Location != null)
            {
                form += " | {2}";
            }

            string eventAsString = string.Format(form, this.D, this.Title, this.Location);
            return eventAsString;
        }

        public int CompareTo(Ev x)
        {
            int res = DateTime.Compare(this.D, x.D);
            foreach (char c in this.Title)
            {
                if (res == 0)
                {
                    res = string.Compare(this.Title, x.Title, StringComparison.Ordinal);
                }

                if (res == 0)
                {
                    res = string.Compare(this.Location, x.Location, StringComparison.Ordinal);
                }
            }

            return res;
        }
    }
}