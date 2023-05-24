using AutoMapper;
using TWMS.Application.CommonContracts;
using TWMS.Domain.Models.Customer;
using TWMS.DTOs.InputDTOs;
using TWMS.DTOs.OutputDTOs;
using TWMS.Infrastructure.Exceptions;
using TWMS.Infrastructure.Persistence.DBContext;
using TWMS.Infrastructure.ServiceContracts;

namespace TWMS.Infrastructure.Services
{
    public class CustomerAddressService : ICustomerAddressService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public CustomerAddressService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<AddressToRetrieve> AddCustomerAddress(Guid customerId, AddressToSave address)
        {
            var customer = await _repositoryManager.customerRepository.GetCustomerById(customerId);
            if (customer == null)
            {
                throw new CustomerNotFoundException(customerId);
            }

            var addressFromDb = await _repositoryManager.customerAddressRepository.GetCustomerAddress(customerId);
            if (addressFromDb != null)
            {
                throw new CustomerAddressExistException(customerId);
            }
            var addressToSave = _mapper.Map<CustomerAddress>(address);
             addressToSave.CustomerId = customerId;
            _repositoryManager.customerAddressRepository.AddCustomerAddress(addressToSave);
            _repositoryManager.Save();
            var addressToRetrieve = _mapper.Map<AddressToRetrieve>(addressToSave);

            return addressToRetrieve;
        }

        public async Task<AddressToRetrieve> GetCustomerAddress(Guid customerId)
        {
            var customer = await _repositoryManager.customerRepository.GetCustomerById(customerId)?? throw new CustomerNotFoundException(customerId);
            
            var address = _repositoryManager.customerAddressRepository.GetCustomerAddress(customerId).Result ?? throw new CustomerAddressNotFoundException(customerId);
            var addressToRetrieve = _mapper.Map<AddressToRetrieve>(address);
            return addressToRetrieve;
        }

        public async Task UpdateCustomerAddress(Guid customerId, AddressToSave address)
        {
            var customer = await _repositoryManager.customerRepository.GetCustomerById(customerId) ?? throw new CustomerNotFoundException(customerId);

            var customerAddress =await _repositoryManager.customerAddressRepository.GetCustomerAddress(customerId);
            if(customerAddress is null)
            {
                throw new CustomerAddressNotFoundException(customerId);
            }
            var addressToUpdate = _mapper.Map<CustomerAddress>(address);
            addressToUpdate.CustomerId = customerId;
            _repositoryManager.customerAddressRepository.UpdateCustomerAddress(addressToUpdate);
            _repositoryManager.Save();
        }


    }
}
