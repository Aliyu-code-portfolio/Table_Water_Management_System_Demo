using Microsoft.EntityFrameworkCore;
using TWMS.Application.CommonContracts;
using TWMS.Infrastructure.Persistence.DBContext;
using TWMS.Domain.Commons;
using System.Linq.Expressions;

namespace TWMS.Infrastructure.Persistence.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class, new()
    {
        private RepositoryContext _AppDbContext;

        public RepositoryBase(RepositoryContext appDbContext)
        {
            _AppDbContext = appDbContext;
        }
        public void Add(T entity)
        {
            _AppDbContext.Set<T>().Add(entity);
            //_AppDbContext.SaveChanges();
        } 
        
        public void Delete(T entity)=>_AppDbContext.Set<T>().Remove(entity);


        public async Task<IQueryable<T>> FindAllAsync(bool trackChanges)
        {
            return trackChanges?  _AppDbContext.Set<T>().AsTracking():
                    _AppDbContext.Set<T>().AsNoTracking();
        }

        public async Task<ICollection<T?>> FindByConditionAsync(Expression<Func<T?, bool>> expression, bool trackChanges)
        {
           return trackChanges? await _AppDbContext.Set<T>().AsTracking().Where(expression).ToListAsync(): 
                                 await _AppDbContext.Set<T>().AsNoTracking().Where(expression).ToListAsync();
        }

        public void Update(T entity)
        {
            _AppDbContext.Set<T>().Update(entity);
        }
    }
}
