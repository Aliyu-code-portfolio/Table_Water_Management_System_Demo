using System;
using TWMS.Domain.Models.Order;

namespace TWMS.Application.Contracts
{
    public interface IOrderItemRepository
    {
        void AddOrderItem(OrderItem item);
        void UpdateOrderItem(OrderItem item);
        void DeleteOrderItem(OrderItem item);
        Task<ICollection<OrderItem>> GetItemsByProductType(int productTypeId);
        Task<ICollection<OrderItem>> GetItemsByOrderId(int orderId);
    }
}
