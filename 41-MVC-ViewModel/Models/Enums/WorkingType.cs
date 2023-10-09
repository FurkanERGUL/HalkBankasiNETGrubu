using System.ComponentModel.DataAnnotations;

namespace _41_MVC_ViewModel.Models.Enums
{
    public enum WorkingType
    {
        [Display(Name = "Tam zamanlı")]
        FullTime=1,
        [Display(Name = "Yarı zamanlı")]
        PartTime,
        [Display(Name = "Proje bazlı")]
        ProjectBased,
        [Display(Name = "Serbest zamanlı")]
        Freelance
    }
}
