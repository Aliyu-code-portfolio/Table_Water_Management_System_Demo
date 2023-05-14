using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Application.Contracts;
using TWMS.Domain.Models.Staff;
using TWMS.Infrastructure.Persistence.DBContext;
using TWMS.Infrastructure.Persistence.Repositories;

namespace TWMS.Infrastructure.Services
{
    public class StaffService: RepositoryBase<Staff>, IStaffService
    {
        public StaffService(AppDbContext appDbContext):base(appDbContext)
        {
            
        }
    }
}
