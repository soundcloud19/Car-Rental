using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Car_sales.Models
{
    public class CarSalesContext : DbContext
    {
        public CarSalesContext(DbContextOptions<CarSalesContext> options)
            : base(options)
        {
        }

        public DbSet<Sales> Sales { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Deliveries> Deliveries { get; set; }
        public DbSet<RefModelTypes> RefModelTypes { get; set; }
        public DbSet<Vehicles> Vehicles { get; set; }

    }
}
