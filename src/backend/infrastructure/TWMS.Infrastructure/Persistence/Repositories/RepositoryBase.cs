using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Application.CommonContracts;
using TWMS.Infrastructure.Persistence.DBContext;
using TWMS.Domain.Commons;

namespace TWMS.Infrastructure.Persistence.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class,IBaseEntity, new()
    {
        private AppDbContext _AppDbContext;

        public RepositoryBase(AppDbContext appDbContext)
        {
            _AppDbContext = appDbContext;
        }
        public void Add(T entity)
        {
            _AppDbContext.Set<T>().Add(entity);
            _AppDbContext.SaveChanges();
        } 

        public void Delete(T entity)=>_AppDbContext.Set<T>().Remove(entity);

        public async Task DeleteById(int id)
        {
            T? data = await GetByIdAsync(false,id);
            Delete(data);
        }

        public async Task<IEnumerable<T>> GetAllAsync(bool trackChanges)
        {
            return trackChanges? await _AppDbContext.Set<T>().AsTracking().ToListAsync():
                   await _AppDbContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T?> GetByIdAsync(bool trackChanges, int id)
        {
            return trackChanges? await _AppDbContext.Set<T>().AsTracking().FirstOrDefaultAsync(n => n.Id == id): 
                                 await _AppDbContext.Set<T>().AsNoTracking().FirstOrDefaultAsync(n=>n.Id==id);

        }

        public void Update(T entity)
        {
            _AppDbContext.Set<T>().Update(entity);
        }
    }
}
