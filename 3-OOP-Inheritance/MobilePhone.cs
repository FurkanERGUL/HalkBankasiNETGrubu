using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_OOP_Inheritance
{
    public class MobilePhone : BasePhone
    {
        public bool HasCamera { get; set; }
        public bool IsTouched { get; set; }

        public MobilePhone()
        {
            _phoneType = "Mobile Phone";
        }
        public MobilePhone(bool hasCamera, bool isTouched, string brand, string connectionType)
        {
            this.HasCamera = hasCamera;
            this.IsTouched = isTouched;

            base._phoneType = "Mobile Phone";
            base.Brand = brand;
            base.ConnectionType = connectionType;
        }

        public string TakePhoto()
        {
            if (this.HasCamera)
            {
                return "You can take a photo";
            }
            else
            {
                return "There is not Camera";
            }
        }

        public override string Call()
        {
            //return "Poliformik Çalıyor";
            return "Poliformik" + base.Call();
        }

        public override string ConnectionStatus()
        {
            return base.ConnectionStatus();
        }

        public override string ToString()
        {
            return "Telefonun Markasi : " + Brand + "Telefon Tipi : " + PhoneType;
        }
    }
}
