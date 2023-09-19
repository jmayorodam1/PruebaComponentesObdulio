using System.Configuration;
using Microsoft.EntityFrameworkCore;
using NLog;
using PruebaComponentesObdulio.Data;
using PruebaComponentesObdulio.Repository;
using Polly.Extensions.Http;
using Polly;
using PruebaComponentesObdulio.Test;

namespace PruebaComponentesObdulio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<TiendaOrdenadoresContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


            // builder.Services.AddScoped<IComponenteRepository, APIComponente>();
            // builder.Services.AddScoped<IOrdenadorRepository, APIOrdenador>();


           //  builder.Services.AddScoped<IComponenteRepository, ComponenteRepository>();
           //  builder.Services.AddScoped<IOrdenadorRepository, OrdenadorRepository>();


            builder.Services.AddScoped<IComponenteRepository, FakeComponenteRepository>();
            builder.Services.AddScoped<IOrdenadorRepository, FakeOrdenadorRepository>();


            builder.Services.AddHttpClient();

            builder.Services.AddControllersWithViews();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Component}/{action=Index}/{id?}");

            app.Run();
        }
    }
}