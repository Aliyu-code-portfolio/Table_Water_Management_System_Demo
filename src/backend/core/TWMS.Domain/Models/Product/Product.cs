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
        public string Name { get; set; }
        public string Description { get; set; } = string.Empty;
/*        public int InventoryId { get; set; }

        public Inventory Inventory { get; set; }*/
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
