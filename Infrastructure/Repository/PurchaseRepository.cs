using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Contracts.Repository;
using System.Linq.Expressions;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class PurchaseRepository : BaseRepository<Purchase>, IPurchaseRepository
    {
        MovieshopDBContext _db;
        public PurchaseRepository(MovieshopDBContext _con) : base(_con)
        {
            _db = _con;
        }
        
    }
}
