using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arteSHub.SoftWareDevelopConsole
{
    public class Stuff:Person
    {

        public decimal MonthSalary { get; }
        public Stuff(string name, decimal monthSalary) : base(name)
        {
            MonthSalary = monthSalary;
        }
    }
}
