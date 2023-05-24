using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using TWMS.Application.CommonContracts;
using TWMS.Domain.Models.Customer;
using TWMS.DTOs.InputDTOs;
using TWMS.DTOs.OutputDTOs;
using TWMS.Infrastructure.Exceptions;
using TWMS.Infrastructure.ServiceContracts;

namespace TWMS.Infrastructure.Services
{
    internal sealed class CustomerService:ICustomerService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public CustomerService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repository = repositoryManager;
            _mapper = mapper;
        }

        public CustomerToRetrieve AddCustomer(CustomerToSave customerDTO)
        {
            var customer = _mapper.Map<Customers>(customerDTO);
            _repository.customerRepository.AddCustomer(customer);
            _repository.Save();

            var customerReturn = _mapper.Map<CustomerToRetrieve>(customer);
            return customerReturn;
        }

        public async Task<IEnumerable<CustomerToRetrieve>> GetAllCustomers()
        {
            var campanies = await _repository.customerRepository.GetAllCustomers();
            if(campanies is null)
            {
                throw new NotFoundException("No Customer Found");
            }
            var companiesToReturn = _mapper.Map<IEnumerable<CustomerToRetrieve>>(campanies);
            return companiesToReturn;
        }

        public async Task<CustomerToRetrieve> GetCustomerByIdAsync(Guid id)
        {
            var customer = await _repository.customerRepository.GetCustomerById(id);
            if(customer is null)
            {
                throw new CustomerNotFoundException(id);
            }
            return _mapper.Map<CustomerToRetrieve>(customer);
        }

        public Task<int> GetCustomerCount()
        {
            return _repository.customerRepository.GetTotalNumberOfCustomersAsync();
        }

        public async Task RemoveCustomer(Guid id)
        {
            var customerToRetrieve = GetCustomerByIdAsync(id);
            if(customerToRetrieve is null)
            {
                throw new CustomerNotFoundException(id);
            }
            var customer = _mapper.Map<Customers>(customerToRetrieve.Result);
            _repository.customerRepository.DeleteCustomer(customer);
            await _repository.customerAddressRepository.DeleteCustomerAddress(id);
            _repository.Save();
        }

        public async Task UpdateCustomerData(Guid id, CustomerToSave customerReceived)
        {
            var customer = await _repository.customerRepository.GetCustomerById(id) ?? throw new CustomerNotFoundException(id);
            var customerToUpdate = _mapper.Map<Customers>(customerReceived);
            customerToUpdate.Id = id;
            _repository.customerRepository.UpdateCustomer(customerToUpdate);
            _repository.Save();
        }
    }
}
