using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Application.CommonContracts;
using TWMS.Domain.Models.Order;

namespace TWMS.Application.Contracts
{
    public interface IOrderRepository
    {
        Task<Order> GetCustomersOrderById(int id);
        Task<ICollection<Order?>> GetAllCustomersOrder(Guid customerId);
        Task<ICollection<Order>> GetAllCustomersPendingOrder(Guid customerId);
        Task<ICollection<Order>> GetAllCustomerOrderByDate(Guid customerId, DateTime? orderDate);
        Task<Order> GetLatestCustomerOrder(Guid customerId);
        void CreateOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(Order order);
    }
}
