using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace _5_OOP_Polymorphism
{
    public class BasePhone
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual void CallSound()
        {
            using (SoundPlayer player = new SoundPlayer("C:\\Users\\halkbank\\Desktop\\projeler\\HalkBankasiNETGrubu\\5-OOP-Polymorphism\\Sounds\\default.wav"))
            {
                player.PlaySync();
            }
        }
    }
}
