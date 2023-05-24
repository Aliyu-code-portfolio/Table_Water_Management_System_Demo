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
    public interface ICustomerAddressService
    {
        Task<AddressToRetrieve> GetCustomerAddress(Guid customerId);
        Task<AddressToRetrieve> AddCustomerAddress(Guid customerId, AddressToSave address);
        Task UpdateCustomerAddress(Guid customerId, AddressToSave customerToUpdate);
    }
}
