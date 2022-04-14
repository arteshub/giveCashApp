using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arteSHub.SoftWareDevelopConsole.Persons
{
    public class Emploee:Stuff
    {
        public Emploee(string name, List<TimeRecorder> timeRecorders) : base(name, 120000, timeRecorders)
        {
             


        }

    }
}
