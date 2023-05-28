using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWMS.Infrastructure.Exceptions
{
    public class OrderNotFoundException:NotFoundException
    {
        public OrderNotFoundException() : base("The request order by the specified condition is not found")
        {

        }
        public OrderNotFoundException(int id):base($"The order with id: {id} is not found in the database.")
        {
            
        }
        public OrderNotFoundException(Guid id):base($"The orders for customer with id {id} are not found in the database ")
        {
            
        }
    }
}
