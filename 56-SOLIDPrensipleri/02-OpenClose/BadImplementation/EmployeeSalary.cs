using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_SOLIDPrensipleri._02_OpenClose.BadImplementation
{
    public class EmployeeSalary
    {
        public Double calculateSalary(Employee employee, int day, double bonus)
        {
            double salary = 0;
            if (employee.EmployeeType=="kadrolu")
            {
                salary = (employee.dailyWages * day) + bonus;
            }
            else if (employee.EmployeeType=="sozlesmeli")
            {
                salary = (employee.dailyWages * day);
            }
            else if (employee.EmployeeType == "stajer") // Sonradan eklendi yanlış
            {
                salary = (employee.dailyWages * day);
            }
            return salary;
        }
    }
}
