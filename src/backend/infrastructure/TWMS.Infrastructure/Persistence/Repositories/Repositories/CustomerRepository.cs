using Microsoft.EntityFrameworkCore;
using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Application.Contracts;
using TWMS.Domain.Models.Customer;
using TWMS.Domain.Models.Order;
using TWMS.Infrastructure.Persistence.DBContext;

namespace TWMS.Infrastructure.Persistence.Repositories.Repositories
{
    public class CustomerRepository:RepositoryBase<Customers>,ICustomerRepository
    {
        private readonly RepositoryContext _appDbContext;
        public CustomerRepository(RepositoryContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;

        }

        public void DeleteCustomer(Customers c)
        {
            Delete(c);
        }

        public void UpdateCustomer(Customers c)
        {
            Update(c);
        }

        public void AddCustomer(Customers c)
        {
            Add(c);
        }
        public Task<IQueryable<Customers>> GetAllCustomers()=> FindAllAsync(false);
        public async Task<Customers> GetCustomerById(Guid? id) =>  FindByConditionAsync(customer => customer.Id == id, false).Result.FirstOrDefault();
        
        //Method to get a list of customers that have made a minTmum total amount of orders
        public async Task<IEnumerable<Customers>> GetCustomersByOrderTotalAsync(decimal minTotal)
        {
            //Testing needed
            List<Customers> customers = new();

            IEnumerable<Order> orders = await _appDbContext.Order.ToListAsync();
            Dictionary<Guid, decimal> orderTotal = new Dictionary<Guid, decimal>();
            foreach (var order in orders)
            {
                if (orderTotal.ContainsKey(order.CustomerId))
                {
                    orderTotal[order.CustomerId] += order.TotalCost;
                }
                else
                {
                    orderTotal.Add(order.CustomerId, order.TotalCost);
                }
            }
            foreach (var customerOrder in orderTotal)
            {
                if (customerOrder.Value >= minTotal)
                {
                    var customer = await _appDbContext.Customers.Where(id => id.Id == customerOrder.Key).FirstOrDefaultAsync();
                    customers.Add(customer);
                }
            }
            return customers;
        }

        public async Task<IEnumerable<Customers>> GetCustomersBySearchAsync(string searchTerm)
        {
            //Testing needed
            if (DateTime.TryParse(searchTerm, CultureInfo.CurrentCulture, out DateTime dateTime))
            {
                return await _appDbContext.Customers.Where(customer => customer.FullName == searchTerm || customer.CreatedDate == dateTime || customer.Birthday == dateTime).ToListAsync();
            }
            else
            {
                return await _appDbContext.Customers.Where(customer => customer.FullName == searchTerm).ToListAsync();
            }

        }
/*
        public async Task<IEnumerable<Customers>> GetCustomersByStreetNameAsync(string streetName)
        {
            //Test needed
            //Considering refactoring the whole code to use appDbContext instead of using ICustomerAddressService DI
            var allCustomerAddress = await _appDbContext.CustomerAddresses.Where(address => address.StreetName.ToLower() == streetName.ToLower()).ToListAsync();
            List<Customers> customers = new();
            foreach (var address in allCustomerAddress)
            {
                var result = await _appDbContext.Customers.Where(customer => customer.CustomerAddressId == address.Id).FirstOrDefaultAsync();
                customers.Add(result);
            }
            return customers.OrderBy(customer => customer.FullName);

        }*/

        public async Task<IEnumerable<Customers>> GetNewestCustomersAsync(int numbersToTake)
        {
            var allCustomers = await _appDbContext.Customers.ToListAsync();
            return allCustomers.OrderByDescending(item => item.CreatedDate).Take(numbersToTake);
        }

        public async Task<IEnumerable<Customers>> GetOldestCustomersAsync(int numbersToTake)
        {
            var allCustomers = await _appDbContext.Customers.ToListAsync();
            return allCustomers.OrderBy(item => item.CreatedDate).Take(numbersToTake);
        }

        public async Task<decimal> GetCustomerOrderTotalAmountAsync(Guid customerId)
        {
            //Test needed
            IEnumerable<Order> customerOrder = await _appDbContext.Order.Where(order => order.CustomerId == customerId).ToListAsync();
            decimal totalAmount = 0;
            foreach (var order in customerOrder)
            {
                totalAmount += order.TotalCost;
            }
            return totalAmount;
        }

        public async Task<IEnumerable<Customers>> GetTopCustomersAsync(int number)
        {
            //Testing needed
            List<Customers> customers = new();

            IEnumerable<Order> orders = await _appDbContext.Order.ToListAsync();
            Dictionary<Guid, decimal> orderTotal = new Dictionary<Guid, decimal>();
            foreach (var order in orders)
            {
                if (orderTotal.ContainsKey(order.CustomerId))
                {
                    orderTotal[order.CustomerId] += order.TotalCost;
                }
                else
                {
                    orderTotal.Add(order.CustomerId, order.TotalCost);
                }
            }
            //var orderRanking = orderTotal.OrderDescending();
            int count = 0;
            foreach (var customerOrder in orderTotal.OrderByDescending(key => key.Value))
            {
                if (count < number)
                {
                    var customer = _appDbContext.Customers.Where(customers => customers.Id == customerOrder.Key).FirstOrDefault();
                    customers.Add(customer);
                    count++;
                }
            }
            return customers;
        }

        public async Task<int> GetTotalNumberOfCustomersAsync()
        {
            var allCustomers = await _appDbContext.Customers.ToListAsync();
            return allCustomers.Count;
        }

    }
}
