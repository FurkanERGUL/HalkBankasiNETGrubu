using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_SOLIDPrensipleri._03_LiscovSubsistion.BadImplementation
{
    public class StandardCar : Car
    {
        public override void Fuel()
        {
            //..........
            base.Fuel();
        }
        public override void Wheels()
        {
            //..........
            base.Wheels();
        }

        public override void Run()
        {
            //.........
            base.Run();
        }
    }
}
