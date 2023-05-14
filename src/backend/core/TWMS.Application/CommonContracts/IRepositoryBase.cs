using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMS.Domain.Commons;

namespace TWMS.Application.CommonContracts
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<T> GetByIdAsync(bool trackChanges, int id);
        Task<IEnumerable<T>> GetAllAsync(bool trackChanges);
        void Add(T entity);
        void Update(T  entity);
        void Delete(T entity);
        Task DeleteById(int id);
    }
}
