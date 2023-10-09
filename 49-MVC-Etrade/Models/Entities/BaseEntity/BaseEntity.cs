using _49_MVC_Etrade.Models.Entities.Enums;

namespace _49_MVC_Etrade.Models.Entities.BaseEntity
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; } = Status.Active;
    }
}
