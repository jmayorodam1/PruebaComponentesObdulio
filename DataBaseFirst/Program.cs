using DataBaseFirst.Models;
using DataBaseFirst.Repository;
using Microsoft.EntityFrameworkCore;

namespace DataBaseFirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<TiendaOrdenadoresContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddScoped<IRepositroy, RepositoryTienda>();

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            // Remove app.UseAuthorization(); if not needed

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=TiendaOrdenadores}/{action=Index}/{id?}");

            app.Run();
        }
    }
}