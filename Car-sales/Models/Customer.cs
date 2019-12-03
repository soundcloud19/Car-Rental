using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_sales.Models
{
    public class Customer
    {
        public long CustomerId { get; set; }
        public string CustomerDetails { get; set; }
        
        public List<Sale> Sale { get; set; }
    }
}
