

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TWMS.Domain.Commons;
using TWMS.Domain.Models.Order;

namespace TWMS.Domain.Models.Customer
{
    public class Customers : AuditableBaseEntity
    {
        [StringLength(20)]
        public string? FullName { get; set; }
        public DateTime Birthday { get; set; }
        [StringLength(11)]
        public string? PhoneNo { get; set; }
        [StringLength(50),Required(ErrorMessage ="Email Address is required")]
        public string? EmailAddress { get; set; }
        //Add customer ID in Sales table
        //Foreign key
        [ForeignKey(nameof(CustomerAddress))]
        public int CustomerAddressId { get; set; }

        public CustomerAddress CustomerAddress { get; set; }
        //public ICollection<OrderItem> Orders { get; set; }
    }
}
