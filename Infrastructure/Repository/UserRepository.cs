using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Contracts.Repository;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly MovieshopDBContext _db;
        public UserRepository(MovieshopDBContext _con) : base(_con)
        {
            _db = _con;
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await _db.Users.Where(x => x.Email == email).FirstOrDefaultAsync();
        }
    }
}
