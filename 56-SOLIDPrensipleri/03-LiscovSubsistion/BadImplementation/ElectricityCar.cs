using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_SOLIDPrensipleri._03_LiscovSubsistion.BadImplementation
{
    public class ElectricityCar : Car
    {
        public override void Wheels()
        {
            base.Wheels();
        }
        public override void Run()
        {
            base.Run();
        }

        //Burada Fuel olmaması gerekiyor
        public override void Fuel()
        {
            throw new Exception("Elektrikli araçta fuel olmaz.");
        }
    }
}
