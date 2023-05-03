using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWMS.Domain.Commons
{
    public abstract class AuditableBaseEntity:BaseEntity
    {
        public string? ModifiedBy { get; set; }
        public DateTime DateModified { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set;}=DateTime.Now;
    }
}
