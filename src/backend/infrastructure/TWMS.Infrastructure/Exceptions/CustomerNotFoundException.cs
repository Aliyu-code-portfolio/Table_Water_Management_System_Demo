using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWMS.Infrastructure.Exceptions
{
    public class CustomerNotFoundException:NotFoundException
    {
        public CustomerNotFoundException(Guid customerId):base($"The Customer with id {customerId} was not found in the database")
        {
            
        }
    }
}
