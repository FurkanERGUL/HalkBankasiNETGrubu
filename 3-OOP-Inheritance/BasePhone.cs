using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_OOP_Inheritance
{
    public class BasePhone
    {
        private string _brand;
        protected string _phoneType;
        protected string _connectionType;

        public BasePhone()
        {
            _phoneType = "Ahizeli Telefon";   
        }

        public BasePhone(string brand, string connectionType)
        {
            _brand = brand;
            _phoneType = "Ahizeli Telefon";
            _connectionType = connectionType;
        }

        public string Brand 
        {
            get { return this._brand; } 
            set { this._brand = value; }
        }

        protected string PhoneType 
        {
            get { return this._phoneType; }
            //set { this._phoneType = value; }
        }

        protected string ConnectionType
        {
            get { return this._connectionType; }
            set { this._connectionType = value; }
        }

        public virtual string Call()
        {
            return " Çalıyor...";
        }

        public virtual string ConnectionStatus()
        {
            return "Kablolu Bağlantı";
        }
    }
}
