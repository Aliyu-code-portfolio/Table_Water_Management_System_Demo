using TWMS.Domain.Models.Customer;
using TWMS.Domain.Commons;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TWMS.Domain.Models.Order
{
    public class Order:AuditableBaseEntity
    {
        public int CustomerId { get; set; }
        [Column(TypeName="money")]
        public decimal TotalCost { get; set; }
        public Customers Customer { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
