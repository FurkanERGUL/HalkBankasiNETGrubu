using Microsoft.AspNetCore.Mvc.Rendering;

namespace _42_MVC_VM2_Futbolcu.Models.VMs
{
    public class ListeVM
    {
        public Futbolcu Futbolcu { get; set; }
        public Mevki Mevki { get; set; }
        public Takim Takim { get; set; }
    }
}
