using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorMegaDesk.Models
{
    public class Shipping
    {
        public int ShippingId { get; set; }
        public string ShippingItemName { get; set; }
        public decimal Cost { get; set; }
    }
}
