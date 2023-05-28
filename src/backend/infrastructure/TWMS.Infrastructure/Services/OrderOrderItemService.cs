using AutoMapper;
using System;
using TWMS.Application.CommonContracts;
using TWMS.Domain.Models.Customer;
using TWMS.Domain.Models.Order;
using TWMS.DTOs.InputDTOs;
using TWMS.DTOs.OutputDTOs;
using TWMS.Infrastructure.Exceptions;
using TWMS.Infrastructure.Persistence.DBContext;
using TWMS.Infrastructure.Persistence.Repositories;
using TWMS.Infrastructure.ServiceContracts;

namespace TWMS.Infrastructure.Services
{
    public class OrderOrderItemService :  IOrderOrderItemService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public OrderOrderItemService(IRepositoryManager repositoryManager, IMapper mapper) 
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }


        public async Task<ICollection<OrderToRetrieve>> GetAllOrderByDate(Guid customerId, DateTime? orderDate)
        {
            var orders = await _repositoryManager.orderRepository.GetAllCustomerOrderByDate(customerId, orderDate) ?? throw new OrderNotFoundException();
            foreach (var order in orders)
            {
                order.OrderItems = await _repositoryManager.orderItemRepository.GetItemsByOrderId(order.Id) ?? throw new OrderItemNotFoundException(order.Id);
            }
            return _mapper.Map<ICollection<OrderToRetrieve>>(orders);//This line neeeds testing
        }

        public async Task<ICollection<OrderToRetrieve>> GetAllOrders(Guid customerId)
        {
            var orders= await _repositoryManager.orderRepository.GetAllCustomersOrder(customerId);
            if(orders is null)
            {
                throw new OrderNotFoundException(customerId);
            }
            foreach (var order in orders)
            {
                order.OrderItems = await _repositoryManager.orderItemRepository.GetItemsByOrderId(order.Id)?? throw new OrderItemNotFoundException(order.Id);
            }
            return _mapper.Map<ICollection<OrderToRetrieve>>(orders);
        }

        public async Task<ICollection<OrderToRetrieve>> GetAllPendingOrder(Guid customerId)
        {
            var orders = await _repositoryManager.orderRepository.GetAllCustomersPendingOrder(customerId) ?? throw new OrderNotFoundException(customerId);
            foreach (var order in orders)
            {
                order.OrderItems = await _repositoryManager.orderItemRepository.GetItemsByOrderId(order.Id) ?? throw new OrderItemNotFoundException(order.Id);
            }
            return _mapper.Map<ICollection<OrderToRetrieve>>(orders);
        }

        public async Task<OrderToRetrieve> GetLatestOrder(Guid customerId)
        {
            var order = await _repositoryManager.orderRepository.GetLatestCustomerOrder(customerId)?? throw new OrderNotFoundException(customerId);
            order.OrderItems = await _repositoryManager.orderItemRepository.GetItemsByOrderId(order.Id)?? throw new OrderItemNotFoundException(order.Id);
            return _mapper.Map<OrderToRetrieve>(order);
        }

        public async Task<OrderToRetrieve> GetOrderById(int id)
        {
            var order = await _repositoryManager.orderRepository.GetCustomersOrderById(id)??throw new OrderNotFoundException(id);
            order.OrderItems = await _repositoryManager.orderItemRepository.GetItemsByOrderId(order.Id)??throw new OrderItemNotFoundException(id);
            return _mapper.Map<OrderToRetrieve>(order);
        }

        public async Task RemoveOrder(Guid customerId, int id)
        {
            var order = await _repositoryManager.orderRepository.GetCustomersOrderById(id)?? throw new OrderNotFoundException(id);
            if (order.CustomerId != customerId)
            {
                throw new OrderNotFoundException(customerId);
            }
            var orderItems = await _repositoryManager.orderItemRepository.GetItemsByOrderId(order.Id) ?? throw new OrderItemNotFoundException(order.Id);
            foreach (var item in orderItems)
            {
                _repositoryManager.orderItemRepository.DeleteOrderItem(item);
            }
            _repositoryManager.orderRepository.DeleteOrder(order);
            _repositoryManager.Save();

        }

        public async Task UpdateOrder(Guid customerId, int id, OrderToSave orderToUpdate)
        {
            var order = await _repositoryManager.orderRepository.GetCustomersOrderById(id)?? throw new OrderNotFoundException(id);
            if (order.CustomerId != customerId)
            {
                throw new OrderNotFoundException(customerId);
            }
            var orderitem = await _repositoryManager.orderItemRepository.GetItemsByOrderId(id)?? throw new OrderNotFoundException(id);
           
            var orderToSave = _mapper.Map<Order>(orderToUpdate);
            orderToSave.DateModified = DateTime.UtcNow;
            orderToSave.ModifiedBy = "Aliyu";// use login session to populate this 
            orderToSave.TotalCost = orderToSave.OrderItems.Sum(item => item.Quantity * item.Price);
            foreach(var item in orderitem)
            {
                _repositoryManager.orderItemRepository.DeleteOrderItem(item);
            }
            foreach(var item in orderToSave.OrderItems) 
            {
                item.OrderId = id;
                _repositoryManager.orderItemRepository.AddOrderItem(item);
            }
            _repositoryManager.orderRepository.UpdateOrder(order);
            _repositoryManager.Save();
        }
        public int CreateOrder(Guid customerId, OrderToSave orderToSave)
        {
            var order= _mapper.Map<Order>(orderToSave);
            order.CustomerId= customerId;
            order.DateModified = DateTime.UtcNow;
            order.ModifiedBy = "Aliyu";// use login session to populate this 
            order.TotalCost = order.OrderItems.Sum(item => item.Quantity * item.Price);
            foreach ( var item in order.OrderItems)
            {
                item.OrderId = order.Id;
                _repositoryManager.orderItemRepository.AddOrderItem(item);
            }
            _repositoryManager.orderRepository.CreateOrder(order);
            _repositoryManager.Save();
            return 33;//Find a better way of getting the id of item just saved to the database

        }
    }
}
