using System;
using TWMS.Domain.Models.Customer;

namespace TWMS.DTOs.OutputDTOs
{
    public sealed record OrderToRetrieve
    {
        public int Id { get; init; }
        public Guid CustomerId { get; init; }
        public decimal TotalCost { get; init; }
        public ICollection<OrderItemToRetrieve> OrderItems { get; init; }
    }
}
