using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arteSHub.SoftWareDevelopConsole
{
    public class Director:Stuff
    {
        public decimal MonthBonus = 20000;
        
        public Director(string name, List<TimeRecorder> timeRecorders) :base( name,200000, timeRecorders) 
        {
            decimal payPerHour = MonthSalary / Settings.WorkHoursInMonth;
            decimal bonusPerDay = (MonthBonus/Settings.WorkHoursInMonth)*Settings.WorkHoursInDay;
            decimal totalPay=0;

            foreach (var timeRecorder in timeRecorders)
            {
                if (timeRecorder.Hours<= Settings.WorkHoursInDay)
                {
                    totalPay += timeRecorder.Hours * payPerHour;
                }else //переработка
                {
                    totalPay += Settings.WorkHoursInDay * payPerHour+ bonusPerDay;
                }
            }

        }
        

    }
}
