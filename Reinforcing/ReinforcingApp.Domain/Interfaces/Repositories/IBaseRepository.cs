using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReinforcingApp.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity Add(TEntity obj);
        Task<TEntity> AddAsync(TEntity obj);
        IEnumerable<TEntity> GetAll();
        TEntity Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}