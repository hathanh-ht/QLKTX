using QLKTX.Domains.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace QLKTX.Domains.Interface
{
    public interface IBaseRepository<TEntity> where TEntity : Entity
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id);
        Task Add(TEntity entity);
        Task Update(TEntity entity);
        Task DeleteAsync(int id);
        IQueryable<TEntity> Queryable(Expression<Func<TEntity, bool>> expression);
    }
}
