using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Application.CommonContracts;
using TWMS.Domain.Models.Customer;

namespace TWMS.Application.Contracts
{
    public interface ICustomerAddressService:IRepositoryBase<CustomerAddress>
    {
    }
}
