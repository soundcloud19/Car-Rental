using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_sales.Models
{
    public class Sales
    {
        public long SaleId{ get; set; }
        public Customers CustomerId { get; set; }
        public Vehicles VehicleId { get; set; }
        public DateTime saleDate { get; set; }
        public string OtherDetails { get; set; }

        public List<Deliveries> Deliveries { get; set; }
    }
}
