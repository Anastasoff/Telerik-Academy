using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarSystem.Contracts
{
    public interface ICommandParser
    {
        Command Parse();
    }
}
