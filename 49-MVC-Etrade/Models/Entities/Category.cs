using _49_MVC_Etrade.Models.Entities.BaseEntity;

namespace _49_MVC_Etrade.Models.Entities
{
    public class Category : BaseEntity.BaseEntity
    {
        public string Name { get; set; }

        public virtual IList<Product> Products { get; set;}
    }
}
