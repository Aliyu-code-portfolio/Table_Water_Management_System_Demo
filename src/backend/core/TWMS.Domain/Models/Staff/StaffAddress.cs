using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Domain.Commons;

namespace TWMS.Domain.Models.Staff
{
    public class StaffAddress : AuditableBaseEntity
    {
        [Key]
       // [ForeignKey(nameof(Staff))]
        public Guid StaffId { get; set; }
        public int BuildingNumber { get; set; }
        [MaxLength(50, ErrorMessage = "Must be less than 50")]
        public string? StreetName { get; set; }
        [MaxLength(50, ErrorMessage = "Must be less than 50")]
        public string? AreaLocality { get; set; }
        [MaxLength(50, ErrorMessage = "Must be less than 50")]
        public string? Landmark { get; set; }
        [MaxLength(50, ErrorMessage = "Must be less than 50")]
        public string? City { get; set; }
        public int Zip_PostalCode { get; set; }
        [MaxLength(50, ErrorMessage = "Must be less than 50")]
        public string? State_Province { get; set; }
        public ICollection<Staff>? Staff { get; set; }
    }
}
