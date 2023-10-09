using Microsoft.AspNetCore.Mvc.Rendering;

namespace _42_MVC_VM2_Futbolcu.Models.VMs
{
    public class CreateVM
    {
        public Futbolcu Futbolcu { get; set; }
        public List<Mevki> Mevkiler { get; set; }
        public List<Takim> Takimlar { get; set; }
    }
}
