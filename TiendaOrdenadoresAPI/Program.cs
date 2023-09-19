using Microsoft.EntityFrameworkCore;
using System;
using TiendaOrdenadoresAPI.Data;
using TiendaOrdenadoresAPI.Models;
using System.Data.Entity;
using TiendaOrdenadoresAPI.Repository;
using TiendaOrdenadoresAPI.Services;

namespace TiendaOrdenadoresAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped(c =>
            {
                var connectionString = builder.Configuration.GetConnectionString("Default") ?? "";
                var dataDirectory = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\.."));
                connectionString = connectionString.Replace("|DataDirectory|", dataDirectory);

                return new Context(connectionString);
            });


            builder.Services.AddScoped<IRepositorio<Componente>, RepositorioComponentes>();
            builder.Services.AddScoped<IRepositorio<Ordenador>, RepositorioOrdenadores>();



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}