using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWMS.DTOs.InputDTOs
{
    public sealed record OrderItemToSave
    {
        //  public int OrderId { get; init; } save this programmably
        public int ProductId { get; init; }
        public int Quantity { get; init; }
        public decimal Price { get; init; }
    }
}
