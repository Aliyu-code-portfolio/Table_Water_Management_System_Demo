using Microsoft.EntityFrameworkCore;
using System;
using TWMS.Application.Contracts;
using TWMS.Domain.Models.Order;
using TWMS.Infrastructure.Persistence.DBContext;

namespace TWMS.Infrastructure.Persistence.Repositories.Repositories
{
    public class OrderRepository :RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(RepositoryContext repository):base(repository)
        {
           
        }
        public void CreateOrder(Order order)
        {
            Add(order);
        }

        public void DeleteOrder(Order order)
        {
            Delete(order);
        }

        public async Task<ICollection<Order>> GetAllCustomersPendingOrder(Guid customerId)
        {
            var allCustomerOrder = await FindByConditionAsync(item => item.CustomerId == customerId, false);
            return allCustomerOrder.Where(item=>item.IsActive==true).ToList();
        }

        public async Task<Order> GetCustomersOrderById(int id)
        {
            return FindByConditionAsync(item => item.Id == id, false).Result.FirstOrDefault();
        }

        public async Task<Order> GetLatestCustomerOrder(Guid customerId)
        {
            return FindByConditionAsync(item => item.CustomerId == customerId, false).Result.OrderByDescending(item => item.CreatedDate).FirstOrDefault(); 
        }                                         

        public void UpdateOrder(Order order)
        {
            Update(order);
        }

        public async Task<ICollection<Order>> GetAllCustomerOrderByDate(Guid customerId, DateTime? orderDate)
        {
            var allCustomerOrder = await FindByConditionAsync(item => item.CustomerId == customerId,false);
            return allCustomerOrder.Where(item=>item.CreatedDate==orderDate).ToList();
        }                                           

        public async Task<ICollection<Order>> GetAllCustomersOrder(Guid customerId)
        {
            return await FindByConditionAsync(item => item.CustomerId == customerId, false);
        }
    }
}
