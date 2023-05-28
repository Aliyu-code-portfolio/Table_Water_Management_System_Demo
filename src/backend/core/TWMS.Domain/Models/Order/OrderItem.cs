
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TWMS.Domain;
using TWMS.Domain.Commons;
using TWMS.Domain.Models.Product;

namespace TWMS.Domain.Models.Order
{
    public class OrderItem:AuditableBaseEntity
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Order))]
        public int? OrderId { get; set; }
        [ForeignKey(nameof(Product))]
        public int? ProductId { get; set; }
        public string? ProductName { get; set; }
        [Range(1,400)]
        public int Quantity { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public virtual Order? Order { get; set; }
        public virtual ProductType? Product { get; set; }
    }
}
