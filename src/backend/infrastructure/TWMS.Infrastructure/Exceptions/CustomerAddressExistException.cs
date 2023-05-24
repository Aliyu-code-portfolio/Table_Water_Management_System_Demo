using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWMS.Infrastructure.Exceptions
{
    public class CustomerAddressExistException:NotFoundException
    {
        public CustomerAddressExistException(Guid id):base($"The customer with id {id} already has an address. Use the PUT request if you want to update")
        {
            
        }
    }
}
