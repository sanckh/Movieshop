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
    public class GenreRepository : BaseRepository<Genre>, IGenreRepository
    {
        //insert, delete, update, getall, getbycondition
        public GenreRepository(MovieshopDBContext _con) : base(_con)
        {

        }

       
    }
}
