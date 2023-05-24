using AutoMapper;
using TWMS.Application.CommonContracts;
using TWMS.Infrastructure.ServiceContracts;

namespace TWMS.Infrastructure.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICustomerService> _customerService;
        private readonly Lazy<ICustomerAddressService> _addressService;   

        public ServiceManager(IRepositoryManager repositoryManager,IMapper mapper)
        {
            _customerService = new Lazy<ICustomerService>(() => new CustomerService(repositoryManager, mapper));
            _addressService = new Lazy<ICustomerAddressService> (()=>new CustomerAddressService(repositoryManager,mapper));
        }
        public ICustomerService CustomerService => _customerService.Value;

        public ICustomerAddressService CustomerAddressService => _addressService.Value;
    }
}
