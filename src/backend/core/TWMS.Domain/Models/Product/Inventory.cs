using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Domain.Commons;

namespace TWMS.Domain.Models.Product
{
    public class Inventory:AuditableBaseEntity
    {
        public int Quantity { get; set; }
       // public int ProductTypeId { get; set; }
        public double ProductionCost { get; set; }
        public DateTime DateProduced { get; set; }
        public double RetailPricePerUnit { get; set; }

        public ICollection<ProductType> Products { get; set;}
    }
}
