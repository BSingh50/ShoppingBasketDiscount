using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products;
using Vouchers;

/// <summary>
/// Please see code for each Basket Scenario below
/// Comment out and remove comments where necessary. The first basket scenario
/// is ready to be tested. After please comment the code and move onto the next basket scenario.
/// 
/// </summary>

namespace ShoppingBasketDiscount
{
    class Program
    {
        static void Main(string[] args)
        {


            var repository = new ProductRepository();
            var basketTotal = new Basket();


            //Basket 1 Scenario

            var basket = repository.Basket1();
            basketTotal.TotalCost = basket.Sum(p => p.Cost);
            basketTotal.GiftVoucherBasket();

            //Basket 2 Scenario

            //var basket = repository.Basket2();
            //var productTypeCost = basket.Where(p => p.Type.Contains("Head Gear")).Sum(p => p.Cost);
            //var productNameGiftVoucherCost = basket.Where(p => p.ProductName.Contains("Gift Voucher")).Sum(p => p.Cost);
            //basketTotal.TotalCost = basket.Sum(p => p.Cost);
            //basketTotal.OfferVoucher(basketTotal.TotalCost, 50.00, "111222", "Head Gear", productTypeCost, 5.00, productNameGiftVoucherCost);

            //Basket 3 Scenario

            //var basket = repository.Basket3();
            //var productTypeCost = basket.Where(p => p.Type.Contains("Head Gear")).Sum(p => p.Cost);
            //var productNameGiftVoucherCost = basket.Where(p => p.ProductName.Contains("Gift Voucher")).Sum(p => p.Cost);
            //basketTotal.TotalCost = basket.Sum(p => p.Cost);
            //basketTotal.OfferVoucher(basketTotal.TotalCost, 50.00, "111333", "Head Gear", productTypeCost, 5.00, productNameGiftVoucherCost);

            //Basket 4 Scenario

            //var basket = repository.Basket4();
            //var productTypeCost = basket.Where(p => p.Type.Contains("Head Gear")).Sum(p => p.Cost);
            //var productNameGiftVoucherCost = basket.Where(p => p.ProductName.Contains("Gift Voucher")).Sum(p => p.Cost);
            //basketTotal.TotalCost = basket.Sum(p => p.Cost);
            //basketTotal.OfferVoucher(basketTotal.TotalCost, 50.00, "111444", "All", 5.00, productNameGiftVoucherCost);
            //basketTotal.GiftVoucherBasket();


            //Basket 5 Scenario

            //var basket = repository.Basket5();
            //var productTypeCost = basket.Where(p => p.Type.Contains("Head Gear")).Sum(p => p.Cost);
            //var productNameGiftVoucherCost = basket.Where(p => p.ProductName.Contains("Gift Voucher")).Sum(p => p.Cost);
            //basketTotal.TotalCost = basket.Sum(p => p.Cost);
            //basketTotal.OfferVoucher(basketTotal.TotalCost, 50.00, "111555", "All", 5.00, productNameGiftVoucherCost);

            Console.WriteLine(basketTotal.ToString());

            Console.Read();


        }
    }
}
