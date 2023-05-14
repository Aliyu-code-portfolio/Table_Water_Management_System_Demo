using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWMS.Domain.Commons
{
    public interface IBaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
