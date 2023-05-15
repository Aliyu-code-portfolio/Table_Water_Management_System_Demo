using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Domain.Models.Customer;
using TWMS.Infrastructure.Persistence.DBContext;
using TWMS.Infrastructure.Persistence.Repositories;

namespace TWMS.Infrastructure.Services
{
    public class CustomerAddressService:RepositoryBase<CustomerAddress>
    {
        private readonly AppDbContext _appDbContext;
        public CustomerAddressService(AppDbContext appDbContext):base(appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
