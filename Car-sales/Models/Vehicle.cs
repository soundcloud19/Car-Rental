using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Car_sales.Models
{
    public class Vehicle
    {
        public long VehicleId { get; set; }
        public RefModelTypes ModelTypeCode { get; set; }
        [Required]
        public string VehicleName { get; set; }
        public DateTime LaunchDate { get; set; }
        public string OtherDetails { get; set; }

        public List<Sale> Sale { get; set; }
    }
}
