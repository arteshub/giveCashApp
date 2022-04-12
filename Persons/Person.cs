using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arteSHub.SoftWareDevelopConsole
{
    public abstract class Person
    {


        string max = "Max";
        public string Name { get; }

        public Person(string name)
        {
            Name = name;
        }




    }
}
