using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWMS.DTOs.OutputDTOs
{
    public sealed record CustomerToRetrieve
    {
        public Guid Id { get; init; }
        public string? FullName { get; init; }
        public DateTime Birthday { get; init; }
        public string? PhoneNo { get; init; }
        public string? EmailAddress { get; init; }
    }
}
