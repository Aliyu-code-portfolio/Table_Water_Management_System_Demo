using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Domain.Models.Order;

namespace TWMS.DTOs.OutputDTOs
{
    public sealed class OrderItemToRetrieve
    {
        public int Id { get; init; }
        public int OrderId { get; init; }
        public int ProductId { get; init; }
        public int Quantity { get; init; }
        public decimal Price { get; init; }
    }
}
