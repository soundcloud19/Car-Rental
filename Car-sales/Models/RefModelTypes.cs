using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_sales.Models
{
    public class RefModelTypes
    {
        [Key]
        public long ModelTypeCode { get; set; }
        public RefModelTypes? ParentModelTypeCode { get; set; }
        public string ModelTypeName { get; set; }

        public List<Vehicle> Vehicle { get; set; }
    }
}
