using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWMS.Application.CommonContracts
{
    public interface IRepositoryBase<T>
    {
        Task<T> GetByIdAsync(bool trackChanges, int id);
        IQueryable<Task<T>> GetAllAsync(bool trackChanges);
        void Add(T entity);
        void Update(T  entity);
        void DeleteById(T entity);
    }
}
