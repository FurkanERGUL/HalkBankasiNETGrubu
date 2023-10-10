using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59_DP_Prototype
{
    public class Employee : ICloneable
    {
        private List<string> employeeList;
        public Employee()
        {
            employeeList= new List<string>();
        }

        public Employee(List<string> employeeList)
        {
            this.employeeList = employeeList;
        }

        public void LoadData()
        {
            employeeList.Add("FRKN");
            employeeList.Add("Naime");
            employeeList.Add("Sefa");
            employeeList.Add("irem");
        }

        public object Clone()
        {
            List<string> temp = new List<string>();
            foreach (var item in GetData())
            {
                temp.Add(item);
            }
            return new Employee(temp);
        }

        public List<string> GetData()
        {
            return employeeList;
        }
    }
}
