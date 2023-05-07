using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Domain.Commons;

namespace TWMS.Domain.Models.Customer
{
    public class CustomerAddress : AuditableBaseEntity
    {
        
        public int BuildingNumber { get; set; }
        [StringLength(50)]
        public string? StreetName { get; set; }
        [StringLength(50)]
        public string? AreaLocality { get; set; }
        [StringLength(50)]
        public string? Landmark { get; set; }
        [StringLength(50)]
        public string? City { get; set; }
        public int Zip_PostalCode { get; set; }
        [StringLength(20)]
        public string? State_Province { get; set; }
        public ICollection<Customers> Customers { get; set; }
    }
}
