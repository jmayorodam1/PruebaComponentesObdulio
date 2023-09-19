


using Microsoft.EntityFrameworkCore;
using PruebaComponentesObdulio.Models;

namespace PruebaComponentesObdulio.Data
{
    public class TiendaOrdenadoresContext : DbContext
    {
        public TiendaOrdenadoresContext(DbContextOptions<TiendaOrdenadoresContext>options) 
            : base(options)
        {

        }

        public DbSet<Componente> Componentes => Set<Componente>();
        public DbSet<Ordenador> Ordenadores => Set<Ordenador>();



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new DbInitializer(modelBuilder).Seed();
            
        }
    }

    public class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            Console.WriteLine("Seeed");
            modelBuilder.Entity<Componente>().HasData(
                new Componente() { Id = 1,
                    NumeroSerie = "789_XCS",
                    Descripcion = "Procesador Intel i7",
                    Calor = 10,
                    Megas = 0,
                    Cores = 9,
                    Coste = 134.0,
                    TipoComponente = 0
                },
                new Componente()
                {
                    Id = 2,
                    NumeroSerie = "789_XCD",
                    Descripcion = "Procesador Intel i7",
                    Calor = 12,
                    Megas = 0,
                    Cores = 10,
                    Coste = 138.0,
                    TipoComponente = 0
                },
                new Componente()
                {

                    Id = 3,
                    NumeroSerie = "789_XCD",
                    Descripcion = "Procesador Intel i7",
                    Calor = 12,
                    Megas = 0,
                    Cores = 10,
                    Coste = 138.0,
                    TipoComponente = 0
                },
                new Componente()
                {
                    Id = 4,
                    NumeroSerie = "879FH",
                    Descripcion = "Banco de memoria SDRAM",
                    Calor = 10,
                    Megas = 512,
                    Cores = 0,
                    Coste = 100.0,
                    TipoComponente = 1
                },
                new Componente()
                {
                    Id = 5,
                    NumeroSerie = "789_XX",
                    Descripcion = "Disco Duro Scan Disk",
                    Calor = 10,
                    Megas = 500000,
                    Cores = 0,
                    Coste = 50.0,
                    TipoComponente = 2
                }

            );
            modelBuilder.Entity<Ordenador>().HasData(
            new Ordenador()
            {
                Id = 1,
                PrecioTotal = 1000.0,
                CalorTotal = 50,
                CoresTotal = 8,
                MegasTotal = 1000
            },
            new Ordenador()
            {
                Id = 2,
                PrecioTotal = 1200.0,
                CalorTotal = 60,
                CoresTotal = 12,
                MegasTotal = 2000
            }
        );



        }
        
    }
    
}
