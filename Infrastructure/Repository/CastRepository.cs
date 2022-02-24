using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Contracts.Repository;

namespace Infrastructure.Repository
{
    public class CastRepository : ICastRepository<Cast>
    {
        IDbConnection dbConnection;

        public CastRepository()
        {
            dbConnection = new SqlConnection();
        }
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Cast Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cast> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Insert(Cast entity)
        {
            throw new NotImplementedException();
        }

        public int Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
