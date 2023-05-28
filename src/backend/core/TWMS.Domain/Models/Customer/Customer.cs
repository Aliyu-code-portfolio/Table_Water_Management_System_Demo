

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TWMS.Domain.Commons;
using TWMS.Domain.Models.Order;

namespace TWMS.Domain.Models.Customer
{
    public class Customers : AuditableBaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(100,ErrorMessage ="Full name must not be more than 100 characters")]
        [Required(ErrorMessage ="Full name is required")]
        public string? FullName { get; set; }
        public DateTime Birthday { get; set; }
        [MaxLength(15,ErrorMessage ="Phone number cannot be more than 15 characters")]
        public string? PhoneNo { get; set; }
        [MaxLength(50),Required(ErrorMessage ="Email Address is required")]
        public string? EmailAddress { get; set; }
        public virtual CustomerAddress? CustomerAddress { get; set; }
        public virtual ICollection<OrderItem>? Orders { get; set; }
    }
}
