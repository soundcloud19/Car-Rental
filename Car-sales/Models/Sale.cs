using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Car_sales.Models
{
    public class Sale
    {
        public long SaleId { get; set; }
        public Customer CustomerId { get; set; }
        public Vehicle VehicleId { get; set; }
        public DateTime SaleDate { get; set; }
        [Required]
        public string OtherDetails { get; set; }

        public List<Delivery> Delivery { get; set; }
    }
}
