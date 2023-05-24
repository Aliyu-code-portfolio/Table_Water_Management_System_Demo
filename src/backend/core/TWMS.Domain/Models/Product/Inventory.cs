using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Domain.Commons;

namespace TWMS.Domain.Models.Product
{
    public class Inventory:AuditableBaseEntity
    {
        [Key]
        public int Id { set; get; }
        public int Quantity { get; set; } = 0;
        [ForeignKey(nameof(ProductType))]
        public int? ProductTypeId { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public double ProductionCost { get; set; }
        public DateTime DateProduced { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public double RetailPricePerUnit { get; set; }

        public ICollection<ProductType>? Products { get; set;}
    }
}
