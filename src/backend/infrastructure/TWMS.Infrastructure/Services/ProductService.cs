using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Application.Contracts;
using TWMS.Domain.Models.Product;
using TWMS.Infrastructure.Persistence.DBContext;
using TWMS.Infrastructure.Persistence.Repositories;

namespace TWMS.Infrastructure.Services
{
    public class ProductService:RepositoryBase<ProductType>,IProductRepository
    {
        private readonly RepositoryContext _appDbContext;
        public ProductService(RepositoryContext appDbContext):base(appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
