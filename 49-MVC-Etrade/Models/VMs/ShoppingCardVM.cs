using _49_MVC_Etrade.Models.Entities;

namespace _49_MVC_Etrade.Models.VMs
{
    public class ShoppingCardVM
    {
        public List<Product> CardItems { get; set; }
        public double Price { get; set; }
    }
}
