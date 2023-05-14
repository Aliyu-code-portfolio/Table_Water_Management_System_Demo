using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Application.CommonContracts;
using TWMS.Domain.Models.Staff;

namespace TWMS.Application.Contracts
{
    public interface IStaffService:IRepositoryBase<Staff>
    {
    }
}
