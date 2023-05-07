using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Domain.Commons;

namespace TWMS.Domain.Models.Staff
{
    public class Guarantor : AuditableBaseEntity
    {
        [StringLength(20)]
        public string? FirstName { get; set; }
        [StringLength(20)]
        public string? LastName { get; set; }
        public DateTime Birthday { get; set; }
        [StringLength(7)]
        public string? Gender { get; set; }
        [StringLength(11)]
        public string? PhoneNo { get; set; }
        [Required(ErrorMessage ="Email address is required"), StringLength(50)]
        public string? EmailAddress { get; set; }
        //Foreign key
        public int GuarantorAddressId { get; set; }

        public GuarantorAddress GuarantorAddress { get; set; }
    }
}
