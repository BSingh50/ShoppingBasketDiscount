using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vouchers;
/// <summary>
/// All 5 Baskets can be viewed below with the specified products 
/// in each method as stated in the Task Sheet
/// 
/// It also implements the Gift Interface
/// </summary>

namespace Products
{
    public class ProductRepository : Gift
    {
        private List<Product> products;



        public IEnumerable<Product> Basket1()
        {
            if (products == null)
            {
                products = new List<Product>();

                products.Add(new Product() {ProductName = "Hat", Cost = 10.50, Quantity = 1, Type = "Head Accessory"});
                products.Add(new Product() { ProductName = "Jumper", Cost = 54.65, Quantity = 1, Type = "Top" });

            }

            return products;
        }

        public IEnumerable<Product> Basket2()
        {
            if (products == null)
            {
                products = new List<Product>();

                products.Add(new Product() { ProductName = "Hat", Cost = 25.00, Quantity = 1, Type = "Head Accessory" });
                products.Add(new Product() { ProductName = "Jumper", Cost = 26.00, Quantity = 1, Type = "Top" });

            }

            return products;
        }

        public IEnumerable<Product> Basket3()
        {
            if (products == null)
            {
                products = new List<Product>();

                products.Add(new Product() { ProductName = "Hat", Cost = 25.00, Quantity = 1, Type = "Head Accessory" });
                products.Add(new Product() { ProductName = "Jumper", Cost = 26.00, Quantity = 1, Type = "Top" });
                products.Add(new Product() { ProductName = "Head Light", Cost = 3.50, Quantity = 1, Type = "Head Gear" });

            }

            return products;
        }

        public IEnumerable<Product> Basket4()
        {
            if (products == null)
            {
                products = new List<Product>();

                products.Add(new Product() { ProductName = "Hat", Cost = 25.00, Quantity = 1, Type = "Head Accessory" });
                products.Add(new Product() { ProductName = "Jumper", Cost = 26.00, Quantity = 1, Type = "Top" });

            }

            return products;
        }

        public IEnumerable<Product> Basket5()
        {
            if (products == null)
            {
                products = new List<Product>();

                products.Add(new Product() { ProductName = "Hat", Cost = 25.00, Quantity = 1, Type = "Head Accessory" });
                products.Add(new Product() { ProductName = "Gift Voucher", Cost = GiftVoucher(), Quantity = 1, Type = "Voucher" });

            }

            return products;
        }

        //Gift Value of 30.00 for Gift as a Product in Basket 5
        public double GiftVoucher()
        {
            return 30.00;
        }
    }
}
