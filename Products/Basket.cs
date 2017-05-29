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
            Message.Append($"Total: {this.TotalCost}");
            
            return Message.ToString();
        }


        public double GiftVoucher()
        {
            return 5.00;
        }

        public void GiftVoucherBasket() => this.TotalCost =
                        this.TotalCost - GiftVoucher();



        public override void OfferVoucher(double currentTotalCost, double threshold, string voucherNum, string productTypeApplied, double productTypeTotal, double offerValue, double giftVoucherValue)
        {
            double remainingCost;
            
            this.TotalCost = currentTotalCost;


            if (currentTotalCost >= threshold && giftVoucherValue == 0)
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


                double actualTotal;

                actualTotal = this.TotalCost - giftVoucherValue;

                double remainingCost2 = actualTotal;
                double costRequired;

                do
                {
                    remainingCost2 += 0.1;
                } while (remainingCost2 <= 50.1);


                remainingCost2 -= actualTotal;

                costRequired = Math.Round(remainingCost2, 2);

                Message.AppendLine();
                Message.Append($"You have not reached the spend threshold for voucher {voucherNum}. Spend another £{costRequired} to receive £{offerValue} discount from your basket total. ").AppendLine().ToString();

            }



        }

        public override void OfferVoucher(double currentTotalCost, double threshold, string voucherNum, string productTypeApplied, double offerValue, double giftVoucherValue)
        {

            this.TotalCost = currentTotalCost;



            if (currentTotalCost >= threshold && giftVoucherValue == 0)
            {

                this.TotalCost -= offerValue;

            }
            else
            {
                double actualTotal;

                actualTotal = this.TotalCost - giftVoucherValue;

                double remainingCost = actualTotal;
                double costRequired;

                do
                {
                    remainingCost += 0.1;
                } while (remainingCost <= 50.1);


                remainingCost -= actualTotal;

                costRequired = Math.Round(remainingCost, 2);

                Message.AppendLine();
                Message.Append($"You have not reached the spend threshold for voucher {voucherNum}. Spend another £{costRequired} to receive £{offerValue} discount from your basket total. ").AppendLine().ToString();


            }



        }

    }
}
