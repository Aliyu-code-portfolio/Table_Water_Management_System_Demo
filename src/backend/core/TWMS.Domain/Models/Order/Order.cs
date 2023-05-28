using TWMS.Domain.Models.Customer;
using TWMS.Domain.Commons;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TWMS.Domain.Models.Order
{
    public class Order:AuditableBaseEntity
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Customer))]
        public Guid CustomerId { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal TotalCost { get; set; }
        public bool IsActive { get; set; } = true;
        public virtual Customers? Customer { get; set; }
        public virtual ICollection<OrderItem>? OrderItems { get; set; }
    }
}
