namespace _49_MVC_Etrade.Models.Entities
{
    public class Product : BaseEntity.BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string? ProductImage { get; set; }
        public string Description { get; set; }

        //Navigation Property
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
