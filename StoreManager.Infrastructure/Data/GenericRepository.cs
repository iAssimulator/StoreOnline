using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using StoreOnline.Core.Interfaces;
using StoreOnline.Infrastructure.Data.EntityFramework;
using StoreOnline.Infrastructure.Interfaces;

namespace StoreOnline.Infrastructure.Data
{
    public abstract class GenericRepository<T> : IRepository<T> where T : class
    {
        protected readonly IStoreOnlineContextFactory<FurnituresContext> ContextFactory;

        protected GenericRepository(IStoreOnlineContextFactory<FurnituresContext> contextFactory)
        {
            ContextFactory = contextFactory;
        }
        
        public virtual IQueryable<T> GetAll()
        {
            IQueryable<T> query = ContextFactory.Create().Set<T>();
            return query;
        }

        public virtual int CountAll()
        {
            return GetAll().Count();
        }

        public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = ContextFactory.Create().Set<T>().Where(predicate);
            return query;
        }

        public virtual void Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity", "Thee given parameter cannot be null.");
            }

            ContextFactory.Create().Set<T>().Add(entity);
        }

        public virtual void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity", "Thee given parameter cannot be null.");
            }

            ContextFactory.Create().Set<T>().Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity", "Thee given parameter cannot be null.");
            }

            var entry = ContextFactory.Create().Entry(entity);
            if(entry.State != EntityState.Added)
                entry.State = EntityState.Modified;
        }

        public virtual void Save()
        {
            ContextFactory.Create().SaveChanges();
        }

        public void Dispose()
        {
            if(ContextFactory != null)
            ContextFactory.Create().Dispose();
        }
    }
}
