using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model.Data
{
    public abstract class BaseRepository<TEntity, Context, TId> : IRepositorio<TEntity> where TEntity : EntidadeBase where Context : DbContext where TId : notnull

    {
        protected readonly Context _context;

        public BaseRepository(Context context)
        {
            _context = context;
        }

        public Context GetContext()
        {
            return _context;
        }

        public virtual async Task<TEntity> Add(TEntity entity)
        {
            entity = BeforeAdd(entity);
            var obj = await _context.Set<TEntity>().AddAsync(entity);
            return AfterAdd(obj.Entity);
        }

        protected virtual TEntity BeforeAdd(TEntity entity)
        {
            return entity;
        }

        protected virtual TEntity AfterAdd(TEntity entity)
        {
            return entity;
        }

        public async Task AddRange(IEnumerable<TEntity> entities)
        {
            try
            {
                entities = BeforeAddRange(entities);
                await _context.Set<TEntity>().AddRangeAsync(entities);
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected virtual IEnumerable<TEntity> BeforeAddRange(IEnumerable<TEntity> entities)
        {
            return entities;
        }

        public TEntity Update(TEntity entity)
        {
            entity = BeforeUpdate(entity);
            _context.Set<TEntity>().Update(entity);
            return AfterUpdate(entity);
        }

        protected virtual TEntity BeforeUpdate(TEntity entity)
        {
            return entity;
        }

        protected virtual TEntity AfterUpdate(TEntity entity)
        {
            return entity;
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().UpdateRange(entities);
        }

        public virtual TEntity Remove(TEntity entity)
        {
            entity = BeforeRemove(entity);
            var obj = _context.Set<TEntity>().Remove(entity);
            return AfterRemove(obj.Entity);
        }

        protected virtual TEntity BeforeRemove(TEntity entity)
        {
            return entity;
        }

        protected virtual TEntity AfterRemove(TEntity entity)
        {
            return entity;
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            entities = BeforeRemoveRange(entities);
            _context.Set<TEntity>().RemoveRange(entities);
        }

        protected virtual IEnumerable<TEntity> BeforeRemoveRange(IEnumerable<TEntity> entities)
        {
            return entities;
        }      

        public async Task RemoveAll()
        {
            try
            {
                var entities = await _context.Set<TEntity>().ToListAsync();
                _context.Set<TEntity>().RemoveRange(entities);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            var set = _context.Set<TEntity>();
            return await AfterGetAll(set);
        }

        protected virtual async Task<IEnumerable<TEntity>> AfterGetAll(DbSet<TEntity> set)
        {
            return await set.ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllWithConditions(Expression<Func<TEntity, bool>> expression)
        {
            try
            {
                var list = (await _context.Set<TEntity>().ToListAsync()).AsQueryable().Where(expression);
                return AfterGetAllWithConditions(list);
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected virtual IEnumerable<TEntity> AfterGetAllWithConditions(IEnumerable<TEntity> list)
        {
            return list;
        }

        public async Task<TEntity> GetById(int id)
        {
            TEntity entity = await _context.Set<TEntity>().FindAsync(id);
            return await AfterGetById(entity);
        }

        public virtual async Task<TEntity> AfterGetById(TEntity entity)
        {
            return await Task.FromResult(entity);
        }

        public async Task ExecuteQuery(string sqlCommand)
        {
            try
            {
                var connection = _context.Database.GetDbConnection();
                if (connection.State != System.Data.ConnectionState.Open)
                    await connection.OpenAsync();

                var command = connection.CreateCommand();
                command.CommandText = sqlCommand;
                var result = await command.ExecuteNonQueryAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }        
    }
}
