using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Domain.Models.Order;

namespace TWMS.Infrastructure.Persistence.Configuration
{
    public class OrderItemConfiguration: IEntityTypeConfiguration<OrderItem>
    {
        private readonly List<OrderItem> _items;
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasData(
                   _items
                );
        }
        public OrderItemConfiguration(List<OrderItem> items)
        {
            _items = items;
        }
    }
}
