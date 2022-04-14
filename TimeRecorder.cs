using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arteSHub.SoftWareDevelopConsole
{
    public class TimeRecorder
    {
        public DateTime Date { get;  }
        public string Name { get;  }

        public byte Hours { get;}

        public string Message { get; }

        public TimeRecorder(DateTime date,string name,byte hours,string message)
        {
            Date=date;
            Name=name;
            Hours=hours;
            Message=message;

        }
    }
}
