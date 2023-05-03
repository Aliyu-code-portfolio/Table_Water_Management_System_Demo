using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Domain.Commons;

namespace TWMS.Domain.Models.Staff
{
    public class Staff : AuditableBaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string? Gender { get; set; }
        public string? PhoneNo { get; set; }
        public string? EmailAddress { get; set; }
        //Foreign key
        public int StaffAddressId { get; set; }
        public int JobTitleId { get; set; }
        public decimal Salary { get; set; }
        public DateTime DateJoined { get; set; }
        //Foreign key
        public int ReportsTo { get; set; }
        //Foreign key
        public int GuarantorId { get; set; }

        public StaffAddress StaffAddress { get; set; }
    }
}
