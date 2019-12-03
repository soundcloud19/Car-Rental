using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_sales.Models
{
    public class Customers
    {
        public long CustomerId { get; set; }
        public string CustomerDetails { get; set; }

        public List<Sales> Sales { get; set; }
    }
}
