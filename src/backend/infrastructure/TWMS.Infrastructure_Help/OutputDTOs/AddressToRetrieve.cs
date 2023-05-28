using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWMS.DTOs.OutputDTOs
{
    public sealed record AddressToRetrieve
    {
        public Guid CustomerId { get; init; }
        public int BuildingNumber { get; init; }
        public string? StreetName { get; init; }
        public string? AreaLocality { get; init; }
        public string? Landmark { get; init; }
        public string? City { get; init; }
        public int Zip_PostalCode { get; init; }
        public string? State_Province { get; init; }
    }
}
