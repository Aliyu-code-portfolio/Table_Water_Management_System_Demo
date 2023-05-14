using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Application.Contracts;
using TWMS.Domain.Models.Customer;
using TWMS.Infrastructure.Persistence.DBContext;
using TWMS.Infrastructure.Persistence.Repositories;

namespace TWMS.Infrastructure.Services
{
    public class CustomerService:RepositoryBase<Customers>,ICustomerService
    {
        private readonly AppDbContext _appDbContext;
        public CustomerService(AppDbContext appDbContext):base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Task<IEnumerable<Customers>> GetCustomersByOrderTotalAsync(decimal minTotal)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customers>> GetCustomersBySearchAsync(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customers>> GetCustomersByStreetNameAsync(string streetName)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Customers>> GetNewestCustomersAsync(int numbersToTake)
        {
            var allCustomers = await _appDbContext.Customers.ToListAsync();
            return allCustomers.OrderByDescending(item=>item.CreatedDate).Take(numbersToTake);
        }

        public async Task<IEnumerable<Customers>> GetOldestCustomersAsync(int numbersToTake)
        {
            var allCustomers = await _appDbContext.Customers.ToListAsync();
            return allCustomers.OrderBy(item=>item.CreatedDate).Take(numbersToTake);
        }

        public Task<Customers> GetOrderTotalAmountAsync(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customers>> GetTopCustomersAsync(int number)
        {
            throw new NotImplementedException();
        }

        public async Task<int> GetTotalNumberOfCustomersAsync()
        {
            var allCustomers = await _appDbContext.Customers.ToListAsync();
            return allCustomers.Count;
        }
    }
}
