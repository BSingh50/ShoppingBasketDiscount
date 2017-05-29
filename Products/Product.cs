using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vouchers;

/// <summary>
/// Product Class which is used by the Product Repository
/// </summary>

namespace Products
{
    public class Product
    {
        public string ProductName { get; set; }
        public double Cost { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }


    }
}
