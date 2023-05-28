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
    public class Guarantor : AuditableBaseEntity
    {
        [Key]
        [ForeignKey(nameof(Staff))]
        public Guid StaffId { get; set; }
        [MaxLength(50, ErrorMessage = "Must be less than 50")]
        public string? FirstName { get; set; }
        [MaxLength(50, ErrorMessage = "Must be less than 50")]
        public string? LastName { get; set; }
        public DateTime Birthday { get; set; }
        [MaxLength(7, ErrorMessage = "Must be less than 7")]
        public string? Gender { get; set; }
        [MaxLength(15, ErrorMessage = "Must be less than 15")]
        public string? PhoneNo { get; set; }
        [MaxLength(50, ErrorMessage = "Must be less than 50")]
        public string? EmailAddress { get; set; }
        //Foreign key
        /*public int GuarantorAddressId { get; set; }*/

        public virtual GuarantorAddress? GuarantorAddress { get; set; }
    }
}
