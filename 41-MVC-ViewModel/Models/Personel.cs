using _41_MVC_ViewModel.Models.Enums;

namespace _41_MVC_ViewModel.Models
{
    public class Personel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Department Department { get; set; }
        public WorkingType WorkingType { get; set; }
    }
}
