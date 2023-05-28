using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Domain.Models.Order;
using TWMS.Application.Contracts;
using TWMS.Infrastructure.Persistence.DBContext;

namespace TWMS.Infrastructure.Persistence.Repositories.Repositories
{
    public class OrderItemRepository : RepositoryBase<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(RepositoryContext repositoryContext):base(repositoryContext)
        {
            
        }

        public void AddOrderItem(OrderItem item)
        {
            Add(item);
        }

        public void DeleteOrderItem(OrderItem item)
        {
            Delete(item);
        }

        public async Task<ICollection<OrderItem>> GetItemsByOrderId(int orderId)
        {
            return await FindByConditionAsync(item => item.OrderId == orderId, false);
        }

        public async Task<ICollection<OrderItem>> GetItemsByProductType(int productTypeId)
        {
            return await FindByConditionAsync(item=>item.ProductId==productTypeId, false);
        }

        public void UpdateOrderItem(OrderItem item)
        {
            Update(item);
        }
    }
}
