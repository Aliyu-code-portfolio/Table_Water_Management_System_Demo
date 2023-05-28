using System;
using TWMS.Domain.Models.Order;
using TWMS.DTOs.InputDTOs;
using TWMS.DTOs.OutputDTOs;

namespace TWMS.Infrastructure.ServiceContracts
{
    public interface IOrderOrderItemService
    {
        Task<ICollection<OrderToRetrieve>> GetAllOrders(Guid customerId);
        Task<OrderToRetrieve> GetOrderById(int id);
        Task<ICollection<OrderToRetrieve>> GetAllPendingOrder(Guid customerId);
        Task<ICollection<OrderToRetrieve>> GetAllOrderByDate(Guid customerId, DateTime? orderDate);
        Task<OrderToRetrieve> GetLatestOrder(Guid customerId);
        Task RemoveOrder(Guid customerId, int id);
        Task UpdateOrder(Guid customerId, int id, OrderToSave orderToSave);
        int CreateOrder(Guid customerId, OrderToSave orderToSave);
    }
}
