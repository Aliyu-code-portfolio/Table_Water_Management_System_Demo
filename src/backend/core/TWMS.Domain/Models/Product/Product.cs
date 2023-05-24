using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Domain.Commons;
using TWMS.Domain.Models.Order;

namespace TWMS.Domain.Models.Product
{
    public class ProductType:AuditableBaseEntity
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50, ErrorMessage = "Must be less than 50")]
        [Required]
        public string? Name { get; set; }
        [StringLength(300, ErrorMessage = "Must be less than 300")]
        public string Description { get; set; } = string.Empty;
/*        public int InventoryId { get; set; }

        public Inventory Inventory { get; set; }*/
        //public ICollection<OrderItem> OrderItems { get; set; }
    }
}
