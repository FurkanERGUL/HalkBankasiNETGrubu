using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OOP_MaasBordroLAB
{
    public class PersonStandard : PersonBase
    {
        private const double _hourlyOvertimeWage = 250;
        public PersonStandard(string name, int age, double hourlyWage, int workingHour) : base(name, age, hourlyWage, workingHour)
        {
           
        }

        public double OvertimeWate { get; set; }

        public override void CalculateWage()
        {
            if (WorkingHour > 160)
            {
                TotalWage = 160 * HourlyWage;

                int overTime = WorkingHour - 160;
                OvertimeWate = overTime * _hourlyOvertimeWage;

                TotalWage += OvertimeWate;
            }
            else 
            {
                base.CalculateWage();
            }
        }
    }
}
