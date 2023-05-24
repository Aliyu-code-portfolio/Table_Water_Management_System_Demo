using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Domain.Models.Customer;

namespace TWMS.Infrastructure.Persistence.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customers>
    {
        protected List<Guid> _ids;
        public void Configure(EntityTypeBuilder<Customers> builder)
        {
            builder.HasData(
                    GenerateCustomersData(10)
                );
        }
        public CustomerConfiguration(ref List<Guid> ids)
        {
            _ids = ids;
        }
        private List<Customers> GenerateCustomersData(int count)
        {
            var customersData = new List<Customers>();
            var random = new Random();

            for (int i = 0; i < count; i++)
            {
                Guid id = Guid.NewGuid();
                _ids.Add(id);
                var customer = new Customers
                {
                    Id = id,
                    ModifiedBy = "John Doe",
                    DateModified = DateTime.Now.AddDays(-random.Next(1, 30)),
                    CreatedBy = "Jane Smith",
                    CreatedDate = DateTime.Now.AddDays(-random.Next(1, 30)),
                    FullName = "Customer " + (i + 1),
                    Birthday = DateTime.Now.AddYears(-random.Next(18, 60)),
                    PhoneNo = "1234567890",
                    EmailAddress = "customer" + (i + 1) + "@example.com",
                };

                customersData.Add(customer);
            }

            return customersData;
        }
    }
}
