using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_SOLIDPrensipleri._02_OpenClose.GoodImplementation
{
    public class RegularyEmployeeSalary : IEmployeeSalary
    {
        public double bonus=0;
        public double CalculateSalary(Employee employee, int day)
        {
            return (employee.dailyWages * day)+bonus;
        }
    }
}
