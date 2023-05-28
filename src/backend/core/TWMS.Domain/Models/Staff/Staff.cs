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
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage ="First name is required")]
        [MaxLength(50, ErrorMessage = "Must be less than 50")]
        public string? FirstName { get; set; }
        [MaxLength(50, ErrorMessage = "Must be less than 50")]
        public string? LastName { get; set; }
        public DateTime Birthday { get; set; }
        [StringLength(7)]
        [Required(ErrorMessage ="Gender is required")]
        public string? Gender { get; set; }
        [MaxLength(15, ErrorMessage = "Must be less than 15")]
        [Required]
        public string? PhoneNo { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Must be less than 50")]
        public string? EmailAddress { get; set; }
        //Foreign key
        /*[ForeignKey(nameof(StaffAddress))]
        public int StaffAddressId { get; set; }*/
        public int? JobTitleId { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Salary { get; set; }
        public DateTime DateJoined { get; set; }
        //Foreign key
        // [ForeignKey(nameof(Staff))]
        //public int ReportsTo { get; set; }
        //Foreign key
        /*[ForeignKey(nameof(Guarantor))]
        public int GuarantorId { get; set; }*/

        public virtual Guarantor? Guarantor { get; set; }
        public virtual StaffAddress? StaffAddress { get; set; }
    }
}
