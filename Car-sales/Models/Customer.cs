using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Car_sales.Models
{
    public class Customer
    {
        public long CustomerId { get; set; }
        [Required]
        public string CustomerDetails { get; set; }
        
        public List<Sale> Sale { get; set; }
    }
}
