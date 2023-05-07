using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWMS.Domain.Commons
{
    public abstract class AuditableBaseEntity:BaseEntity
    {
        [StringLength(50)]
        public string? ModifiedBy { get; set; }
        public DateTime DateModified { get; set; }
        [StringLength(50)]
        public string? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set;}=DateTime.Now;
    }
}
