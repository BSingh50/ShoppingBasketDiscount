using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Offer Abstract Class
/// </summary>

namespace Vouchers
{
    public abstract class Offer
    {
        private string VoucherNumber { get; set; }
        private double Threshold { get; set; }
        private string ProductTypeApplied { get; set; }
        private double OfferValue { get; set; }


        public virtual void OfferVoucher(double currentTotalCost, double threshold, string voucherNum, 
            string productTypeApplied, double productTypeTotal, double offerValue, double giftVoucherValue)
        {


        }

        public virtual void OfferVoucher(double currentTotalCost, double threshold, string voucherNum, string productTypeApplied, double offerValue, double giftVoucherValue)
        {


        }

    }
}
