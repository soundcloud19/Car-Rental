using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_sales.Models
{
    public class Delivery
    {
        public long DeliveryId { get; set; }
        public Sale SaleId { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string OtherDetails { get; set; }
    }
}
