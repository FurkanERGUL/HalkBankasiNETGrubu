using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_SOLIDPrensipleri._03_LiscovSubsistion.GoodImplemantation
{
    public class FuelCar : Car
    {
        public override void Run()
        {
            base.Run();
        }
        public override void Wheels()
        {
            base.Wheels();
        }

        public virtual void Fuel()
        {
            
        }
    }
}
