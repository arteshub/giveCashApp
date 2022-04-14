using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arteSHub.SoftWareDevelopConsole
{
    public class Freelancer:Person
    {
        public Freelancer(string name, List<TimeRecorder> timeRecorders) :base(name,timeRecorders)
        {
            
        }
    }
}
