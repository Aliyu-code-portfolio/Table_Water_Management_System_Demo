using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWMS.Domain.Commons
{
    public abstract class AuditableBaseEntity
    {
        [MaxLength(50,ErrorMessage ="Must be less than 50")]
        public string? ModifiedBy { get; set; }
        public DateTime DateModified { get; set; }
        [StringLength(50)]
        [MaxLength(50, ErrorMessage = "Must be less than 50")]
        public string? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set;}=DateTime.Now;
    }
}
