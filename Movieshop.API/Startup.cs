using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Infrastructure.Repository;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

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
            service.AddCors(option => {
                option.AddDefaultPolicy(builder => {
                    builder.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod().AllowCredentials();
                });
            });
            //service.AddControllersWithViews();
            //service.AddMvc();

            //Repositories
            service.AddScoped<IGenreRepository, GenreRepository>();
            service.AddScoped<IMovieRepository, MovieRepository>();
            service.AddScoped<ICastRepository, CastRepository>();
            service.AddScoped<IUserRepository, UserRepository>();

            //Services
            service.AddScoped<IGenreService, GenreService>();
            service.AddScoped<IMovieService, MovieService>();
            service.AddScoped<ICastService, CastService>();
            service.AddScoped<IAccountService, AccountService>();

            //database injection
            service.AddDbContext<MovieshopDBContext>(option =>
            {
                option.UseSqlServer(Configuration.GetConnectionString("MovieShopDb"));
            });

            //inject jwt token service
            service.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(option =>
                {
                    option.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["PrivateKey"]))
                    };
                }
                );

        }

        // Middleware
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseCors();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            
        }
    }
}