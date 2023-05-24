using AutoMapper;
using TWMS.Domain.Models.Customer;
using TWMS.DTOs.InputDTOs;
using TWMS.DTOs.OutputDTOs;

namespace TWMS.WebAPI.MapProfile
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Customers, CustomerToRetrieve>();
            CreateMap<CustomerToSave, Customers>();
            CreateMap<CustomerToRetrieve, Customers>();
            CreateMap<CustomerAddress,AddressToRetrieve>();
            CreateMap<AddressToSave, CustomerAddress>();
        }
    }
}
