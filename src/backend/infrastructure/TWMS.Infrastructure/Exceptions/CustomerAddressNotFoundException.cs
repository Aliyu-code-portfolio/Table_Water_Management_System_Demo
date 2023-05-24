using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWMS.Infrastructure.Exceptions
{
    public class CustomerAddressNotFoundException:NotFoundException
    {
        public CustomerAddressNotFoundException(Guid id):base($"Address not found on the database for customer {id}")
        {
            
        }
    }
}
