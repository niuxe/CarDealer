using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using CarDealerDataLayer.Models;

namespace CarDealerDataLayer.DAL
{
    public class CarDealerDBContext : DbContext
    {
        public CarDealerDBContext(DbContextOptions<CarDealerDBContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<SalesPerson> SalesPersons { get; set; }
        public DbSet<CarPurchase> CarPurchases { get; set; }

    }
}
