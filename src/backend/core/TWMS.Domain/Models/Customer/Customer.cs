using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Domain.Commons;
using TWMS.Domain.Models.Order;
using TWMS.Domain.Models.Product;

namespace TWMS.Domain.Models.Customer
{
    public class Customer : AuditableBaseEntity
    {
        public string? FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string? PhoneNo { get; set; }
        public string? EmailAddress { get; set; }
        //Add customer ID in Sales table
        //Foreign key
        public int CustomerAddressId { get; set; }

        public CustomerAddress CustomerAddress { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
