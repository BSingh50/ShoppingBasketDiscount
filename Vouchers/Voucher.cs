using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Voucher class
/// </summary>

namespace Vouchers
{
    public class Voucher
    {

        public string VoucherName { get; set; }
        public decimal Amount { get; set; }
        public string VoucherCode { get; set; }

        public Voucher()
        {

        }

        public Voucher(string voucherName, decimal amount, string voucherCode)
        {
            this.VoucherName = voucherName;
            this.Amount = amount;
            this.VoucherCode = voucherCode;
        }

    }
}
