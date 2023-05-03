using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Domain.Commons;

namespace TWMS.Domain.Models.Staff
{
    public class Guarantor : AuditableBaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string? Gender { get; set; }
        public string? PhoneNo { get; set; }
        public string? EmailAddress { get; set; }
        //Foreign key
        public int GuarantorAddressId { get; set; }

        public GuarantorAddress GuarantorAddress { get; set; }
    }
}
