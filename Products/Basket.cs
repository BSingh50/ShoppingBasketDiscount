using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vouchers;
using Products;

/// <summary>
/// The code for Offer Voucher and Gift Vouchers are set up here by
/// inheriting the Offer abstract class and Implementing the Gift Interface
/// </summary>

namespace ShoppingBasketDiscount
{
    public class Basket : Offer, Gift
    {

        public double TotalCost { get; set; }
        public StringBuilder Message = new StringBuilder();
        public Basket()
        {

        }

        public Basket(double totalCost)
        {
            
            this.TotalCost = totalCost;
        }

        public override string ToString()
        {
            Message.Append($"Total: £{this.TotalCost}");
            
            return Message.ToString();
        }

        /// <summary>
        /// Implementing the Gift Voucher method and assiging a value to it
        /// </summary>
        /// <returns>Gift Voucher Value</returns>
        public double GiftVoucher()
        {
            return 5.00;
        }

        /// <summary>
        /// Method to calculate the gift voucher for the total cost of a basket
        /// </summary>
        public void GiftVoucherBasket() => this.TotalCost =
                        this.TotalCost - GiftVoucher();


        /// <summary>
        /// Inheriting the method OfferVoucher in order to calculate the total cost of the basket
        /// 
        /// 
        /// </summary>
        /// <param name="currentTotalCost"> Total cost of basket</param>
        /// <param name="threshold"> threshold assinged</param>
        /// <param name="voucherNum"> Voucher Number</param>
        /// <param name="productTypeApplied"> The type of Product e.g. "Head Gear"</param>
        /// <param name="productTypeTotal"> The total cost for that product type </param>
        /// <param name="offerValue"> The value of the Offer Voucher</param>
        /// <param name="giftVoucherValue"> Gift Voucher Value in case a gift voucher is added as a product </param>
        public override void OfferVoucher(double currentTotalCost, double threshold, string voucherNum, string productTypeApplied, double productTypeTotal, double offerValue, double giftVoucherValue)
        {
            double remainingCost;
            
            this.TotalCost = currentTotalCost;

            currentTotalCost -= giftVoucherValue;

            //Checking against the threshold and if the gift voucher has a value
            if (currentTotalCost >= threshold)
            {
                if (productTypeTotal != 0)
                {
                    remainingCost = currentTotalCost - productTypeTotal;
                    productTypeTotal -= offerValue;

                    this.TotalCost = remainingCost + productTypeTotal;
                }

                else
                {
                    Message.Append($"There are no products in your basket applicable to voucher {voucherNum}").AppendLine().ToString();
                }
            }
            else
            {


                double remainingCost2 = currentTotalCost;
                double costRequired;

                do
                {
                    remainingCost2 += 0.1;
                } while (remainingCost2 <= 50.1);


                remainingCost2 -= currentTotalCost;

                costRequired = Math.Round(remainingCost2, 2);

                Message.AppendLine();
                Message.Append($"You have not reached the spend threshold for voucher {voucherNum}. Spend another £{costRequired} to receive £{offerValue} discount from your basket total. ").AppendLine().ToString();

            }



        }

        public override void OfferVoucher(double currentTotalCost, double threshold, string voucherNum, double offerValue, double giftVoucherValue)
        {

            this.TotalCost = currentTotalCost;

            currentTotalCost -= giftVoucherValue;

            if (currentTotalCost >= threshold)
            {

                this.TotalCost -= offerValue;

            }
            else
            {

                double remainingCost = currentTotalCost;
                double costRequired;

                do
                {
                    remainingCost += 0.1;
                } while (remainingCost <= 50.1);


                remainingCost -= currentTotalCost;

                costRequired = Math.Round(remainingCost, 2);

                Message.AppendLine();
                Message.Append($"You have not reached the spend threshold for voucher {voucherNum}. Spend another £{costRequired} to receive £{offerValue} discount from your basket total. ").AppendLine().ToString();


            }



        }

    }
}
