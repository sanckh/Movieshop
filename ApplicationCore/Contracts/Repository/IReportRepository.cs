using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Repository
{
    public interface IReportRepository<T> where T : class
    {
        int Insert(T entity);
        int Update(int id);
        int Delete(int id);
        IEnumerable<T> GetAll();
        T Get(int id);
    }
}
