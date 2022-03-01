using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Contracts.Repository;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class CastRepository : BaseRepository<Cast>, ICastRepository
    {
        MovieshopDBContext _db;
        public CastRepository(MovieshopDBContext _con) : base(_con)
        {
            _db = _con;
        }
        public Cast GetCast(int id)
        {
            return _db.Casts.Where(x=>x.Id == id).FirstOrDefault();
        }

    }
}
