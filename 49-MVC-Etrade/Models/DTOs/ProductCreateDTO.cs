namespace _49_MVC_Etrade.Models.DTOs
{
    public class ProductCreateDTO
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string ProductImage { get; set; }
        public string Description { get; set; }
    }
}
