using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Domain.Models.Customer;
using TWMS.Domain.Models.Order;

namespace TWMS.Infrastructure.Persistence.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        private readonly List<Guid> _orderIds;
        private readonly List<OrderItem> _items;
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(
                   GenerateCustomersOrderData(10)
                );
        }
        public OrderConfiguration(List<Guid> ids,ref List<OrderItem> items)
        {
            _orderIds = ids;
            _items = items;

        }
        private List<Order> GenerateCustomersOrderData(int count)
        {
            var customersOrderData = new List<Order>();
            var random = new Random();
            int counter = 1;
            for (int i = 0; i < count; i++)
            {
               for(int j = 0; j < 2; j++)
                {
                    var order = new Order
                    {
                        Id =counter++,
                        ModifiedBy = "John Doe",
                        DateModified = DateTime.Now.AddDays(-random.Next(1, 30)),
                        CreatedBy = "Jane Smith",
                        CreatedDate = DateTime.Now.AddDays(-random.Next(1, 30)),
                        CustomerId = _orderIds[i],
                        OrderItems = new List<OrderItem>()
                    };
                    var orderItem = new OrderItem
                    {
                        Id = counter++,
                        ModifiedBy = "John Doe",
                        DateModified = DateTime.Now.AddDays(-random.Next(1, 30)),
                        CreatedBy = "Jane Smith",
                        CreatedDate = DateTime.Now.AddDays(-random.Next(1, 30)),
                        Price = (decimal)random.Next(100, 500),
                        ProductId = j + 1,
                        OrderId = order.Id,
                        Quantity = random.Next(20, 300),
                    };
                    var orderItem2 = new OrderItem
                    {
                        Id = counter++,
                        ModifiedBy = "John Doe",
                        DateModified = DateTime.Now.AddDays(-random.Next(1, 30)),
                        CreatedBy = "Jane Smith",
                        CreatedDate = DateTime.Now.AddDays(-random.Next(1, 30)),
                        Price = (decimal)random.Next(100, 500),
                        ProductId = j + 1,
                        OrderId = order.Id,
                        Quantity = random.Next(20, 300),
                    };
                    order.OrderItems.Add(orderItem);
                    order.OrderItems.Add(orderItem2);
                    _items.Add(orderItem);
                    _items.Add(orderItem2);
                    order.TotalCost = order.OrderItems.Sum(item => item.Price * item.Quantity);
                    order.OrderItems = null;
                    customersOrderData.Add(order);

                }
            }

            return customersOrderData;
        }
    }
}
