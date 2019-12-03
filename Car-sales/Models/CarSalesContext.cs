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

        public DbSet<Sale> Sale { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Delivery> Delivery { get; set; }
        public DbSet<RefModelTypes> RefModelTypes { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }

    }
}
