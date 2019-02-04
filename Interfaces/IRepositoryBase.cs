using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace TodoApp.Interfaces
{
    public interface IRepositoryBase<TEntity>
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression);
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        // Save probably is anti-pattern here if we have multiple database connections going on here
        void Save();
    }
}
