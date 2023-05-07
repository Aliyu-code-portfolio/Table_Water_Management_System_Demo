using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWMS.Domain.Models.Staff
{
    public class JobTitle
    {
        public int Id { get; set; }
        [StringLength(10)]
        public string? Title { get; set; }

        public ICollection<Staff> Staff { get; set; }
    }
}
