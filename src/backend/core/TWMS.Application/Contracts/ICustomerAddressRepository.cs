using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Application.CommonContracts;
using TWMS.Domain.Models.Customer;

namespace TWMS.Application.Contracts
{
    public interface ICustomerAddressRepository
    {
        Task<CustomerAddress> GetCustomerAddress(Guid? id);
        void AddCustomerAddress(CustomerAddress customerAddress);
        void UpdateCustomerAddress(CustomerAddress customerAddress);

    }
}
