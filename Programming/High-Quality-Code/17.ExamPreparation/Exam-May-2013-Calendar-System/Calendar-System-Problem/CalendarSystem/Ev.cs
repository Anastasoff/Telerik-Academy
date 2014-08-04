using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarSystem
{
    public class Ev : IComparable<Ev>
    {
        public DateTime d { get; set; }

        public string Title;

        public string Location;

        public override string ToString()
        {
            string form = "{0:yyyy-MM-ddTH:mm:ss} | {1}";
            if (this.Location != null)
            {
                form += " | {2}";
            }
            string eventAsString = string.Format(form, this.d, this.Title, this.Location);
            return eventAsString;
        }

        public int CompareTo(Ev x)
        {
            int res = DateTime.Compare(this.d, x.d);
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
