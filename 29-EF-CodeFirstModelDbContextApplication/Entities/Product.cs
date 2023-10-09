using _29_EF_CodeFirstModelDbContextApplication.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_EF_CodeFirstModelDbContextApplication.Entities
{
    public class Product : BaseEntity
    {
        public Product()
        {
            //ProductDate = DateTime.Now;
        }
        //public int ProductID { get; set; }
        public string ProductName { get; set; }
        //public Status ProductStatu { get; set; }
        //public DateTime ProductDate { get; set; }

        private int _stock=10;
        public int Stock
        {
            get { return _stock; }
            set 
            {
                if (value>=0)
                {
                    _stock = value;
                }
                else
                {
                    Console.WriteLine("Stok 0 dan küçük olamaz");
                    _stock = 0;
                }
            }
        }
        private double _price;
        public double Price
        {
            get { return _price; }
            set 
            {
                if (value>0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Fiyat 0 veya 0'dan küçük olamaz.");
                }
            }
        }

        public int CategoryRefID { get; set; }
        public virtual Category Category { get; set; }
        public virtual ProductDetails ProductDetail { get; set; }

    }
}
