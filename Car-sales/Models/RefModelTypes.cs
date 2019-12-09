using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Car_sales.Models
{
    public class RefModelTypes
    {
        [Key]
        public long ModelTypeCode { get; set; }
        public RefModelTypes? ParentModelTypeCode { get; set; }
        [Required]
        public string ModelTypeName { get; set; }

        public List<Vehicle> Vehicle { get; set; }
    }
}
