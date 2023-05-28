using Microsoft.EntityFrameworkCore;
using TWMS.Domain.Models.Customer;
using TWMS.Domain.Models.Order;
using TWMS.Domain.Models.Product;
using TWMS.Domain.Models.Staff;
using TWMS.Infrastructure.Persistence.Configuration;

namespace TWMS.Infrastructure.Persistence.DBContext
{
    public class RepositoryContext:DbContext
    {
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<StaffAddress> StaffAddresses { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options ):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerAddress>()
                .HasKey(e => new { e.CustomerId } );
            modelBuilder.Entity<Guarantor>()
                .HasKey(e => new { e.StaffId } );
            modelBuilder.Entity<GuarantorAddress>()
                .HasKey(e => new { e.StaffId });
            modelBuilder.Entity<StaffAddress>()
                .HasKey(e => new { e.StaffId });
            List<Guid> ids = new List<Guid>();
            List<OrderItem> items = new List<OrderItem>();
            modelBuilder.ApplyConfiguration(new CustomerConfiguration(ref ids));
            modelBuilder.ApplyConfiguration(new CustomerAddressConfiguration(ids));
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration(ids,ref items));
            modelBuilder.ApplyConfiguration(new OrderItemConfiguration(items));
        }
    }
}
