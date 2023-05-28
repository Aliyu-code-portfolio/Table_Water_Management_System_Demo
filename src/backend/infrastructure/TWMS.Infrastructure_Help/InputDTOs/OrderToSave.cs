using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.DTOs.OutputDTOs;

namespace TWMS.DTOs.InputDTOs
{
    public sealed record OrderToSave
    {
        public Guid CustomerId { get; init; }
        public decimal TotalCost { get; init; }
        public bool IsActive { get; init; }
        public ICollection<OrderItemToSave> OrderItems { get; init; }
    }
}
