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
    public class Staff : AuditableBaseEntity
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
        [StringLength(50)]
        public string? EmailAddress { get; set; }
        //Foreign key
        [ForeignKey(nameof(StaffAddress))]
        public int StaffAddressId { get; set; }
        public int JobTitleId { get; set; }
        [Column(TypeName = "money")]
        public decimal Salary { get; set; }
        public DateTime DateJoined { get; set; }
        //Foreign key
        // [ForeignKey(nameof(Staff))]
        //public int ReportsTo { get; set; }
        //Foreign key
        [ForeignKey(nameof(Guarantor))]
        public int GuarantorId { get; set; }

        public Guarantor Guarantor { get; set; }
        public StaffAddress StaffAddress { get; set; }
    }
}
