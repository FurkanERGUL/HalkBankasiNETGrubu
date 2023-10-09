using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OOP_MaasBordroLAB
{
    public class PersonBase
    {
        //Fields
        private string _name;
        private int _age;
        private double _hourlyWage;
        private int _workingHour;

        public PersonBase(string name, int age, double hourlyWage, int workingHour)
        {
            this.Name = name;
            this.BirthDate = age;
            this.HourlyWage = hourlyWage;
            this.WorkingHour = workingHour;
        }

        //Properties
        public string Name 
        {
            get { return _name; }
            protected set { _name = value.ToUpper(); }
        }

        public int BirthDate 
        {
            get { return _age; }
            protected set
            {
                if(DateTime.Now.Year - value>=18)
                    _age = DateTime.Now.Year - value;
                else
                    Console.WriteLine("18 Yaşından küçük personel çalıştırılamaz.");
            }
        }

        public int WorkingHour 
        { 
            get { return _workingHour; }
            set
            { 
                if(value>0)
                    _workingHour = value;
                else
                    Console.WriteLine("Çalışma saati 0 dan küçük olamaz.");
            }
        }

        public double HourlyWage 
        {
            get { return _hourlyWage; }
            protected set 
            {
                if (value >= 200)
                    _hourlyWage = value;
                else
                    _hourlyWage = 200;
            } 
        }

        public double TotalWage { get; protected set; }

        /// <summary>
        /// Personelin maaşını hesaplayan metot.
        /// </summary>
        public virtual void CalculateWage()
        {
            Console.WriteLine("Maaş Hesaplanıyor...");
            TotalWage = _workingHour * _hourlyWage;
        }

        public override string ToString()
        {
            return $"\nAdi: {Name}\nYaş: {BirthDate}\nSaatlik Ücret: {HourlyWage}\nÇalışma Saati: {WorkingHour}\nMaaş: {TotalWage}";
        }
    }
}
