using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_sales.Models
{
    public class Deliveries
    {
        public long DeliveryId { get; set; }
        public Sales SaleId { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string OtherDetails { get; set; }
    }
}
