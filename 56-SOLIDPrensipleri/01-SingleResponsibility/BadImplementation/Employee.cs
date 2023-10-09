using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_SOLIDPrensipleri.SingleResponsibility.BadImplementation
{
    public class Employee
    {
        //Fields
        
        private string dateOfJoning; //İkisi içinde yapmışsın gibi düşün
        private double salary;
        private string fullName;
        //Properties
        

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }


        public double CalculateEmployeeSalary { get; set; }
        public double CalculateTaxOnSalary { get; set; }

        public void SaveEmployee()
        {
            //Kaydet 
        }

        public void UpdateEmployee()
        {
            //Güncelle
        }
    }
}
