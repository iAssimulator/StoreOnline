using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using StoreOnline.Core.Models;

namespace StoreOnline.Core.Interfaces
{
    //public interface IRepository<T> where T : BaseEntity
    public interface IRepository<T> : IDisposable
        where T : class
    {
        IQueryable<T> GetAll();
        int CountAll();
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
        void Save();
    }
}
