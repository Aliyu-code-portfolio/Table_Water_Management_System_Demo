using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Domain.Models.Customer;
using TWMS.DTOs.InputDTOs;
using TWMS.DTOs.OutputDTOs;

namespace TWMS.Infrastructure.ServiceContracts
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerToRetrieve>> GetAllCustomers();
        Task<CustomerToRetrieve> GetCustomerByIdAsync(Guid id);
        CustomerToRetrieve AddCustomer(CustomerToSave customer);
        void RemoveCustomer(Guid id);
        Task UpdateCustomerData(Guid id, CustomerToSave customer);
        Task<int> GetCustomerCount();
    }
}
