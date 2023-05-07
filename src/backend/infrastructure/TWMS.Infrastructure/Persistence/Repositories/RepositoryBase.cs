using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Application.CommonContracts;
using TWMS.Infrastructure.Persistence.DBContext;

namespace TWMS.Infrastructure.Persistence.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private AppDbContext _AppDbContext;

        public RepositoryBase(AppDbContext appDbContext)
        {
            _AppDbContext = appDbContext;
        }
        public void Add(T entity) => _AppDbContext.Set<T>().Add(entity);

        public void DeleteById(T entity)=>_AppDbContext.Set<T>().Remove(entity);

        public IQueryable<Task<T>> GetAllAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(bool trackChanges, int id)
        {
            throw new NotImplementedException();
            //return _AppDbContext.Set<T>().Where

        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
