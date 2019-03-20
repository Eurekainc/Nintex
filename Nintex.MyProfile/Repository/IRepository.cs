using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nintex.MyProfile.Repository
{
    public interface IRepository<T> where T : class
    {
        T Create();
        T GetById(object id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> Table { get; }
        IQueryable<T> GetQueryable(bool includeDeleted = false);
    }
}
