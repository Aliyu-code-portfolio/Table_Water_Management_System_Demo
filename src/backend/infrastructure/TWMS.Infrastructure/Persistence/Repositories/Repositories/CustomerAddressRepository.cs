using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Application.Contracts;
using TWMS.Domain.Models.Customer;
using TWMS.Infrastructure.Persistence.DBContext;

namespace TWMS.Infrastructure.Persistence.Repositories.Repositories
{
    public class CustomerAddressRepository : RepositoryBase<CustomerAddress>, ICustomerAddressRepository
    {
        public CustomerAddressRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public void AddCustomerAddress(CustomerAddress customerAddress)
        {
            Add(customerAddress);
        }

        public async Task DeleteCustomerAddress(Guid id)
        {
            var address =  FindByConditionAsync(item => item.CustomerId == id, false).Result.FirstOrDefault();
            Delete(address);
        }

        public async Task<CustomerAddress> GetCustomerAddress(Guid? id) =>  FindByConditionAsync(item => item.CustomerId == id, false).Result.FirstOrDefault();

        public void UpdateCustomerAddress(CustomerAddress customerAddress)
        {
            Update(customerAddress);
        }
    }
}
