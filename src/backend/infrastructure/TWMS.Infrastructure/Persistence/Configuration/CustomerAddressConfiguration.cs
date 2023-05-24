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
    public class CustomerAddressConfiguration : IEntityTypeConfiguration<CustomerAddress>
    {
        private List<Guid> _ids;
        public void Configure(EntityTypeBuilder<CustomerAddress> builder)
        {
            builder.HasData
                (
                    GenerateAddressesData(10)
                );
        }
        public CustomerAddressConfiguration(List<Guid> ids)
        {
            _ids = ids;
        }
        private List<CustomerAddress> GenerateAddressesData(int count)
        {
            var addressesData = new List<CustomerAddress>();
            var random = new Random();

            for (int i = 0; i < count; i++)
            {
                var address = new CustomerAddress
                {
                    CustomerId = _ids[i],
                    ModifiedBy = "John Doe",
                    DateModified = DateTime.Now.AddDays(-random.Next(1, 30)),
                    CreatedBy = "Jane Smith",
                    CreatedDate = DateTime.Now.AddDays(-random.Next(1, 30)),
                    BuildingNumber = random.Next(1, 100),
                    StreetName = "Street " + (i + 1),
                    AreaLocality = "Area " + (i + 1),
                    Landmark = "Landmark " + (i + 1),
                    City = "City " + (i + 1),
                    Zip_PostalCode = random.Next(10000, 99999),
                    State_Province = "State " + (i + 1),
                    Customers = new List<Customers>() // Initialize an empty list of Customers
                };

                addressesData.Add(address);
            }

            return addressesData;
        }
    }
}
