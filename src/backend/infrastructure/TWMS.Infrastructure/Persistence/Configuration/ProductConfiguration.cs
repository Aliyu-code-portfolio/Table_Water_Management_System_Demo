using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Domain.Models.Product;

namespace TWMS.Infrastructure.Persistence.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<ProductType>
    {
        public void Configure(EntityTypeBuilder<ProductType> builder)
        {
            builder.HasData(
                    new ProductType
                    {
                        Id = 1,
                        Name ="pure water",
                        Description="Water in sachets"
                    },
                    new ProductType
                    {
                        Id = 2,
                        Name = "bottle water",
                        Description = "Water in bottle"
                    }
                ); ;
        }
    }
}
