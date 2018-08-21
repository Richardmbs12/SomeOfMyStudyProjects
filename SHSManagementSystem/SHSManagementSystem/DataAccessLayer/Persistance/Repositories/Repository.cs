using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccessLayer.Persistance.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;
        protected readonly DbSet<TEntity> entity;

        public Repository(DbContext context)
        {
            Context = context;
            entity = Context.Set<TEntity>();
        }

        public TEntity Get(int id)
        {
            return entity.Find(id);
        }

        public IEnumerable<TEntity> GetAll(IEnumerable<Expression<Func<TEntity, object>>> includes)
        {
            return entity.IncludeMultiple(includes).ToList();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate , IEnumerable<Expression<Func<TEntity, object>>> includes)
        {
            return entity.IncludeMultiple(includes).Where(predicate).ToList();
        }

        public void Add(TEntity entity)
        {
            this.entity.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            entity.AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            this.entity.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            entity.RemoveRange(entities);
        }
    }
}
