using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Application.Contracts;
using TWMS.Domain.Models.Customer;

namespace TWMS.Infrastructure_Help.Post_Model.Customer
{
   
    public record CustomerRecord(string fullName,DateTime birthday, string phoneNo, 
        string emailAddress, int buildingNumber, string streetName, string areaLocality, 
        string landmark, string city, int zipCode, string stateProvince);
    
    
}
