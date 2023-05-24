using System;
using TWMS.Application.CommonContracts;
using TWMS.Application.Contracts;
using TWMS.Domain.Models.Customer;
using TWMS.Domain.Models.Order;
using TWMS.Domain.Models.Product;
using TWMS.Domain.Models.Staff;
using TWMS.Infrastructure.Persistence.DBContext;
using TWMS.Infrastructure.Persistence.Repositories.Repositories;

namespace TWMS.Infrastructure.Persistence.Repositories
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<ICustomerRepository> _customerRepository;
        private readonly Lazy<ICustomerAddressRepository> _customerAddressRepository;
        private readonly Lazy<IStaffRepository> _staffRepository;
        private readonly Lazy<IStaffAddressRepository> _staffAddressRepository;
        private readonly Lazy<IProductRepository> _productRepository;
        private readonly Lazy<IOrderRepository> _orderRepository;
        private readonly Lazy<IOrderItemRepository> _orderItemRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _customerRepository = new Lazy<ICustomerRepository>(() => new CustomerRepository(repositoryContext));
            _customerAddressRepository= new Lazy<ICustomerAddressRepository>(() => new CustomerAddressRepository(repositoryContext));
        }
        public ICustomerRepository customerRepository => _customerRepository.Value;

        public ICustomerAddressRepository customerAddressRepository => _customerAddressRepository.Value;

        public IStaffRepository staffRepository => throw new NotImplementedException();

        public IStaffAddressRepository staffAddressRepository => throw new NotImplementedException();

        public IProductRepository productRepository => throw new NotImplementedException();

        public IOrderRepository orderRepository => throw new NotImplementedException();

        public IOrderItemRepository orderItemRepository => throw new NotImplementedException();

        public void Save()
        {
            _repositoryContext.SaveChanges();
        }
    }
}
