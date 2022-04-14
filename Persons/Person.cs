using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arteSHub.SoftWareDevelopConsole
{
    public abstract class Person
    {



        public string Name { get; }
        public List<TimeRecorder> TimeRecorders { get; set; }

        public Person(string name, List<TimeRecorder> timeRecorders)
        {
            Name = name;
            TimeRecorders = timeRecorders;
        }




    }
}
