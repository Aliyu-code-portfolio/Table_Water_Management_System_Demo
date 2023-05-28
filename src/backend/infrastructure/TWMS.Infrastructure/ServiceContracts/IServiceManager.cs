using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWMS.Infrastructure.ServiceContracts
{
    public interface IServiceManager
    {
        ICustomerService CustomerService { get; }
        ICustomerAddressService CustomerAddressService { get; }
        IOrderOrderItemService OrderOrderItemService { get; }
    }
}
