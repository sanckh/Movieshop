using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Infrastructure.Repository;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

namespace Movieshop.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration config)
        {
            Configuration = config;
        }
        // Dependency Injection
        public void ConfigureServices(IServiceCollection service)
        {
            service.AddControllers();
            //service.AddControllersWithViews();
            //service.AddMvc();

            //Repositories
            service.AddScoped<IGenreRepository, GenreRepository>();
            service.AddScoped<IMovieRepository, MovieRepository>();
            service.AddScoped<ICastRepository, CastRepository>();

            //Services
            service.AddScoped<IGenreService, GenreService>();
            service.AddScoped<IMovieService, MovieService>();
            service.AddScoped<ICastService, CastService>();

            service.AddDbContext<MovieshopDBContext>(option =>
            {
                option.UseSqlServer(Configuration.GetConnectionString("MovieShopDb"));
            });

        }

        // Middleware
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}