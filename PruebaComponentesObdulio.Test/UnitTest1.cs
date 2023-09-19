using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using PruebaComponentesObdulio.Controllers;
using PruebaComponentesObdulio.Data;
using PruebaComponentesObdulio.Models;
using PruebaComponentesObdulio.Repository;
using Microsoft.EntityFrameworkCore.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebaComponentesObdulio.Test
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void Index_ReturnsViewWithListOfComponents()
        {
            var options = new DbContextOptionsBuilder<TiendaOrdenadoresContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            var dbContext = new TiendaOrdenadoresContext(options);

            var components = new List<Componente>
            {
                new Componente
                {
                    Id = 1,
                    Calor = 10,
                    Cores = 9,
                    Coste = 134.0,
                    Descripcion = "Procesador Intel i7",
                    Megas = 0L,
                    NumeroSerie = "789_XCS",
                    TipoComponente = 0
                },
                new Componente
                {
                    Id = 2,
                    Calor = 12,
                    Cores = 10,
                    Coste = 138.0,
                    Descripcion = "Procesador Intel i7",
                    Megas = 0L,
                    NumeroSerie = "789_XCD",
                    TipoComponente = 0
                }
            };

            dbContext.Componentes.AddRange(components);
            dbContext.SaveChanges();

            var repository = new ComponenteRepository(dbContext);
            var controller = new ComponentController(repository);

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            var model = result.Model as IEnumerable<Componente>;
            Assert.IsNotNull(model);
            Assert.AreEqual(2, model.Count());
        }




        [TestMethod]
        public void Agregar_AgregaComponenteCorrectamente()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<TiendaOrdenadoresContext>()
          .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
          .EnableSensitiveDataLogging() // Habilitar el registro de datos sensibles
          .Options;

            var dbContext = new TiendaOrdenadoresContext(options);

            var componenteRepository = new ComponenteRepository(dbContext);
            var componente = new Componente
            {
                Id = 5,
                Calor = 20,
                Cores = 8,
                Coste = 150.0,
                Descripcion = "Nueva CPU",
                Megas = 0L,
                NumeroSerie = "123_ABC",
                TipoComponente = 0
            };
            var componente2 = new Componente
            {
                Id = 6,
                Calor = 15,
                Cores = 8,
                Coste = 150.0,
                Descripcion = "Nueva CPU",
                Megas = 0L,
                NumeroSerie = "123_ABC",
                TipoComponente = 0
            };

            // Act
            componenteRepository.Agregar(componente);
            componenteRepository.Agregar(componente2);

            // Assert
            Assert.AreEqual(2, dbContext.Componentes.Count());
            var result = dbContext.Componentes.Find(5); // ID del componente actualizado
            Assert.IsNotNull(result);
            Assert.AreEqual(20, result.Calor);
            var result2 = dbContext.Componentes.Find(6); // ID del componente actualizado
            Assert.IsNotNull(result2);
            Assert.AreEqual(15, result2.Calor);


             var todos = componenteRepository.ObtenerTodos();

            // Assert
            Assert.AreEqual(2, todos.Count());

            // Assert
        }

        [TestMethod]
        public void ActualizarComponenteCorrectamente()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<TiendaOrdenadoresContext>()
         .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
         .EnableSensitiveDataLogging() // Habilitar el registro de datos sensibles
         .Options;
            var dbContext = new TiendaOrdenadoresContext(options);

            var componenteRepository = new ComponenteRepository(dbContext);
            var componenteOriginal = new Componente
            {
                Id = 6,
                Calor = 20,
                Cores = 8,
                Coste = 150.0,
                Descripcion = "Nueva CPU",
                Megas = 0L,
                NumeroSerie = "123_ABC",
                TipoComponente = 0
            };

            // Act
            componenteRepository.Agregar(componenteOriginal);

            // Obtener el componente agregado
            var componenteObtenido = dbContext.Componentes.Find(6);

            // Actualizar el componente obtenido
            componenteObtenido.Calor = 25;
            componenteObtenido.Cores = 6;
            componenteObtenido.Coste = 160.0;
            componenteObtenido.Descripcion = "CPU Actualizada";
            componenteObtenido.NumeroSerie = "123_XYZ";

            componenteRepository.Actualizar(componenteObtenido);

            // Assert
            Assert.AreEqual(1, dbContext.Componentes.Count());
            var result = dbContext.Componentes.Find(6); // ID del componente actualizado
            Assert.IsNotNull(result);
            Assert.AreEqual(25, result.Calor);
        }






        [TestMethod]
        public void Eliminar_EliminaComponenteCorrectamente()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<TiendaOrdenadoresContext>()
           .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
           .EnableSensitiveDataLogging() // Habilitar el registro de datos sensibles
           .Options;
            var dbContext = new TiendaOrdenadoresContext(options);

            var componenteRepository = new ComponenteRepository(dbContext);
            var componente = new Componente
            {
                Id = 7, // ID del componente existente que deseas eliminar
                Calor = 12,
                Cores = 10,
                Coste = 138.0,
                Descripcion = "Procesador Intel i7",
                Megas = 0L,
                NumeroSerie = "789_XCD",
                TipoComponente = 0
            };

            componenteRepository.Agregar(componente);

            // Act
            componenteRepository.Eliminar(7);

            // Assert
            var deletedComponente = dbContext.Componentes.Find(7); // ID del componente eliminado
            Assert.IsNull(deletedComponente);
            Assert.AreEqual(0, dbContext.Componentes.Count());

        }



    }
}
