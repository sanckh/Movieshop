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
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class CastRepository : BaseRepository<Cast>, ICastRepository
    {
        MovieshopDBContext _db;
        public CastRepository(MovieshopDBContext _con) : base(_con)
        {
            _db = _con;
        }
        public async Task<Cast> GetCastAsync(int id)
        {
            return await _db.Casts.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

    }
}
