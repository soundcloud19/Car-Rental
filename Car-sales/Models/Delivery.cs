using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Car_sales.Models
{
    public class Delivery
    {
        public long DeliveryId { get; set; }
        public Sale SaleId { get; set; }
        public DateTime DeliveryDate { get; set; }
        [Required]
        public string OtherDetails { get; set; }
    }
}
