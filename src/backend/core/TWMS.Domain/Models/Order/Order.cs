using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Domain.Commons;
using TWMS.Domain.Models.Customer;


namespace TWMS.Domain.Models.Order
{
    public class Order:AuditableBaseEntity
    {
        public int CustomerId { get; set; }
        public decimal TotalCost { get; set; }

        public Customer Customer { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
