using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Repository
{
    public interface IRepository<T> where T: class
    {
        int Insert(T entity);
        int Update(T entity);
        int Delete(int id);
        IEnumerable<T> GetAll();
        T GetByCondition(Expression<Predicate<T>> filter);
    }
}
