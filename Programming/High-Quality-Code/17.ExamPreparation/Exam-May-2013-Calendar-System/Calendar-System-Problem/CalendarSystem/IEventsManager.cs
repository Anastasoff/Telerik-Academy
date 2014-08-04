using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarSystem
{
    public interface IEventsManager
    {
        void AddEvent(Ev a);

        int DeleteEventsByTitle(string b);

        IEnumerable<Ev> ListEvents(DateTime c, int d);
    }
}
