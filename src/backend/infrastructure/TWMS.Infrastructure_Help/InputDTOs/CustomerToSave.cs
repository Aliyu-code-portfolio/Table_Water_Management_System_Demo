using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWMS.DTOs.InputDTOs
{
    public record CustomerToSave
    {
        public string? FullName { get; init; }
        public DateTime Birthday { get; init; }
        public string? PhoneNo { get; init; }
        public string? EmailAddress { get; init; }
        //public AddressToSave? CustomerAddress { get; init; } //for saving customer and address together
    }
}
