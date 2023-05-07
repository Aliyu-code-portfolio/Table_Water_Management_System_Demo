using Microsoft.EntityFrameworkCore;
using TWMS.Domain.Models.Customer;
using TWMS.Domain.Models.Order;
using TWMS.Domain.Models.Product;
using TWMS.Domain.Models.Staff;

namespace TWMS.Infrastructure.Persistence.DBContext
{
    public class AppDbContext:DbContext
    {
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<StaffAddress> StaffAddresses { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options ):base(options)
        {
            
        }
    }
}
