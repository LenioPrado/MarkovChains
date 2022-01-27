using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model.Data
{
    public interface IRepositorio<TEntity> where TEntity : EntidadeBase
    {
        Task<TEntity> Add(TEntity entity);

        Task AddRange(IEnumerable<TEntity> entities);

        TEntity Remove(TEntity entity);

        void RemoveRange(IEnumerable<TEntity> entities);

        Task RemoveAll();

        TEntity Update(TEntity entity);

        void UpdateRange(IEnumerable<TEntity> entities);

        Task<IEnumerable<TEntity>> GetAll();

        Task<IEnumerable<TEntity>> GetAllWithConditions(Expression<Func<TEntity, bool>> expression);

        Task<TEntity> GetById(int id);

        Task ExecuteQuery(string sqlCommand);

        Task<int> SaveChanges();
    }
}
