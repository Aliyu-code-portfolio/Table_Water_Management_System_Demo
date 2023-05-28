using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TWMS.Domain.Commons;

namespace TWMS.Application.CommonContracts
{
    public interface IRepositoryBase<T> 
    {
        Task<ICollection<T?>> FindByConditionAsync(Expression<Func<T?, bool>> expression, bool trackChanges);
        Task<IQueryable<T>> FindAllAsync(bool trackChanges);
        void Add(T entity);
        void Update(T  entity);
        void Delete(T entity);
    }
}
