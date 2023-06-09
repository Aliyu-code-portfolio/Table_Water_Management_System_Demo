﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Application.CommonContracts;
using TWMS.Domain.Models.Customer;

namespace TWMS.Application.Contracts
{
    public interface ICustomerRepository
    {
        Task<IQueryable<Customers>> GetAllCustomers();
        Task<Customers?> GetCustomerById(Guid? id);
        void DeleteCustomer(Customers c);
        void UpdateCustomer(Customers c);
        void AddCustomer(Customers c);
        Task<int> GetTotalNumberOfCustomersAsync();
        Task<IEnumerable<Customers>> GetNewestCustomersAsync(int numbersToTake);
        Task<IEnumerable<Customers>> GetOldestCustomersAsync(int numbersToTake);
        //Task<IEnumerable<Customers>> GetCustomersByStreetNameAsync(string streetName);
        Task<IEnumerable<Customers>> GetCustomersBySearchAsync(string searchTerm);
        Task<IEnumerable<Customers>> GetTopCustomersAsync(int number);
        Task<IEnumerable<Customers>> GetCustomersByOrderTotalAsync(decimal minTotal);
        Task<decimal> GetCustomerOrderTotalAmountAsync(Guid customerId);
    }
}
