using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_SOLIDPrensipleri._02_OpenClose.GoodImplementation
{
    public class ContractedEmployeeSalary : IEmployeeSalary
    {
        public double CalculateSalary(Employee employee, int day)
        {
            return (employee.dailyWages * day);
        }
    }
}
