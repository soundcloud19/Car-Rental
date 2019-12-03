using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_sales.Models
{
    public class Vehicles
    {
        public long VehicleId { get; set; }
        public RefModelTypes ModelTypeCode { get; set; }
        public string VehicleName { get; set; }
        public DateTime LaunchDate { get; set; }
        public string OtherDetails { get; set; }

        public List<Sales> Sales { get; set; }
    }
}
