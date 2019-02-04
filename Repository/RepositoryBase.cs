using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using TodoApp.Interfaces;

namespace TodoApp.Repository
{
    public abstract class RepositoryBase<TEnitiy> : IRepositoryBase<TEnitiy> where TEnitiy : class
    {
        protected RepositoryContext RepositoryContext { get; set; }

        public RepositoryBase(RepositoryContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }

        public void Create(TEnitiy entity)
        {
            RepositoryContext.Set<TEnitiy>().Add(entity);
        }

        public void Delete(TEnitiy entity)
        {
            RepositoryContext.Set<TEnitiy>().Remove(entity);
        }

        public IEnumerable<TEnitiy> Find(Expression<Func<TEnitiy, bool>> expression)
        {
            return RepositoryContext.Set<TEnitiy>().Where(expression);
        }

        public TEnitiy Get(int id)
        {
            return RepositoryContext.Set<TEnitiy>().Find(id);
        }

        public IEnumerable<TEnitiy> GetAll()
        {
            return RepositoryContext.Set<TEnitiy>().ToList();
        }

        public void Update(TEnitiy entity)
        {
            RepositoryContext.Set<TEnitiy>().Remove(entity);
        }

        public void Save()
        {
            RepositoryContext.SaveChanges();
        }

    }
}
