using AutoMapper;
using TWMS.Application.CommonContracts;
using TWMS.Infrastructure.ServiceContracts;

namespace TWMS.Infrastructure.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICustomerService> _customerService;
        private readonly Lazy<ICustomerAddressService> _addressService;
        private readonly Lazy<IOrderOrderItemService> _orderOrderItemService;

        public ServiceManager(IRepositoryManager repositoryManager,IMapper mapper)
        {
            _customerService = new Lazy<ICustomerService>(() => new CustomerService(repositoryManager, mapper));
            _addressService = new Lazy<ICustomerAddressService> (()=>new CustomerAddressService(repositoryManager,mapper));
            _orderOrderItemService = new Lazy<IOrderOrderItemService>(() => new OrderOrderItemService(repositoryManager, mapper));
        }
        public ICustomerService CustomerService => _customerService.Value;

        public ICustomerAddressService CustomerAddressService => _addressService.Value;

        public IOrderOrderItemService OrderOrderItemService => _orderOrderItemService.Value;
    }
}
