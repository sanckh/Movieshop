using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;


namespace Infrastructure.Data
{
    public class MovieshopDBContext : DbContext
    {
        //will generate the DB tables
        public MovieshopDBContext(DbContextOptions<MovieshopDBContext> options) :base(options)
        {
            //specify options

            
        }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<Genre> Genres { get; set; }

    }
}
