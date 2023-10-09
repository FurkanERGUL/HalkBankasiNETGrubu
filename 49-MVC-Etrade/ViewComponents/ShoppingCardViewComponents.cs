using _49_MVC_Etrade.Models.Entities;
using _49_MVC_Etrade.Models.VMs;
using Microsoft.AspNetCore.Mvc;

namespace _49_MVC_Etrade.ViewComponents
{
    public class ShoppingCardViewComponents : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var cardItems = new List<Product>()
            {
                new Product
                {
                    CategoryId= 1,
                    Description="Kahve",
                    Name="TürkKahvesi",
                    Price=50,
                    Stock=50,
                    ProductImage="sakd"
                }
            };
            var model = new ShoppingCardVM
            {
                CardItems = cardItems,
                Price = CalculateTotalPrice(cardItems)
            };
            return View(model);
        }
        public double CalculateTotalPrice(List<Product> products)
        {
            double totalPrice = 0;
            foreach (var product in products)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }
    }
}
