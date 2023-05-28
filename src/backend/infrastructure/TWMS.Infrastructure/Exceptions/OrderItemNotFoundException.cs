using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWMS.Infrastructure.Exceptions
{
    public class OrderItemNotFoundException:NotFoundException
    {
        public OrderItemNotFoundException(int id):base($"The order item for order with id {id} does not exist")
        {
            
        }
    }
}
