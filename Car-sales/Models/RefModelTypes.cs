using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_sales.Models
{
    public class RefModelTypes
    {
        public string ModelTypeCode { get; set; }
        public RefModelTypes? ParentModelTypeCode { get; set; }
        public string ModelTypeName { get; set; }

        public List<Vehicles> Vehicles { get; set; }
    }
}
