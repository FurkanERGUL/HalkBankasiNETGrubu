using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace _5_OOP_Polymorphism
{
    public class Samsung : BasePhone
    {
        public override void CallSound()
        {
            using (SoundPlayer player = new SoundPlayer("C:\\Users\\halkbank\\Desktop\\projeler\\HalkBankasiNETGrubu\\5-OOP-Polymorphism\\Sounds\\samsung.wav"))
            {
                player.PlaySync();
            }
        }
    }
}
