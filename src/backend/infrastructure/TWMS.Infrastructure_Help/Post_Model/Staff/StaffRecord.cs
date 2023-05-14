using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWMS.Infrastructure_Help.Post_Model.Staff
{
    public record StaffRecord(string firstName,string lastName, DateTime birthday,string gender, string phoneNo,
        string emailAddress, int buildingNumber, string streetName, string areaLocality,
        decimal salary,DateTime datejoined, string landmark, string city, int zipCode, string stateProvince,
        string guarantorFirstName,string guarantorLastName,DateTime guarantorBirthday, string guarantorGender,
        string guarantorPhoneNo, string guarantorEmail);
}
