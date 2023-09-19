using Microsoft.AspNetCore.Mvc;
using Ejercicio3.Componentes;
using PruebaComponentesObdulio.Models;
using TiendaOrdenadoresAPI.Controllers;
using TiendaOrdenadoresAPI.Repository;
using Componente = TiendaOrdenadoresAPI.Models.Componente;
using Ordenador = TiendaOrdenadoresAPI.Models.Ordenador;

using TiendaOrdenadoresAPI.Services;
using Ejercicio3.Tipos;
using PruebaComponentesObdulio.Controllers;

namespace TiendaOrdenadoresApi.Test
{
    [TestClass]
    public class TestComponentesController
    {
        private FakeRepositorioComponentes _fakeRepositoryComponentes;
        private FakeRepositorioOrdenadores _fakeRepositoryOrdenadores;

        private readonly ComponentesController controladorComponente = new(new FakeRepositorioComponentes());
        private Componente _fakeComponente;

        private readonly TiendaOrdenadoresAPI.Controllers.OrdenadorController controladorOrdenador = new(new FakeRepositorioOrdenadores());
        private Ordenador _fakeOrdenador;

        [TestInitialize]
        public void TestSetup()
        {
            _fakeRepositoryComponentes = new FakeRepositorioComponentes();
            _fakeComponente = _fakeRepositoryComponentes.Obtener(1);
            _fakeRepositoryOrdenadores = new FakeRepositorioOrdenadores();
            _fakeOrdenador = _fakeRepositoryOrdenadores.Obtener(1);
        }

        [TestMethod]
        public void TestObtenerTodosComponentes()
        {
            var resultado = controladorComponente.Get() as OkObjectResult;
            Assert.IsNotNull(resultado);
            var componentes = resultado.Value as List<Componente>;
            Assert.IsNotNull(componentes);
            Assert.AreEqual(3, componentes.Count);
        }

        [TestMethod]
        public void TestObtenerComponenteExiste()
        {
            var resultado = controladorComponente.Get(1) as ObjectResult;
            Assert.IsNotNull(resultado);
            var componente = resultado.Value as TiendaOrdenadoresAPI.Models.Componente;
            Assert.IsNotNull(componente);
            Assert.AreEqual("Procesador Intel i7", componente.Descripcion);
            Assert.AreEqual(10, componente.Calor);
            Assert.AreEqual(9, componente.Cores);
            Assert.AreEqual(134.0, componente.Coste);
            Assert.AreEqual("789_XCS", componente.NumeroSerie);
            Assert.AreEqual(0, componente.Megas);
        }

        [TestMethod]
        public void TestObtenerComponenteNoExiste()
        {
            var resultado = controladorComponente.Get(6) as NotFoundResult;
            Assert.IsNotNull(resultado);
        }

        [TestMethod]
        public void TestComponenteCrear()
        {
            var resultado = controladorComponente.Get() as OkObjectResult;
            Assert.IsNotNull(resultado);
            var listaModulos = resultado.Value as List<TiendaOrdenadoresAPI.Models.Componente>;
            Assert.IsNotNull(listaModulos);
            Assert.AreEqual(3, listaModulos.Count);

            Componente componente = new()
            {
                Descripcion = "Prueba",
                NumeroSerie = "BBBB"
            };

            controladorComponente.Post(componente);
            resultado = controladorComponente.Get() as OkObjectResult;
            Assert.IsNotNull(resultado);
            listaModulos = resultado.Value as List<Componente>;
            Assert.IsNotNull(listaModulos);
            Assert.AreEqual(4, listaModulos.Count);
        }

        [TestMethod]
        public void TestComponenteBorrar()
        {
            var resultado = controladorComponente.Get() as OkObjectResult;
            Assert.IsNotNull(resultado);
            var listaModulos = resultado.Value as List<Componente>;
            Assert.IsNotNull(listaModulos);
            Assert.AreEqual(3, listaModulos.Count);

            controladorComponente.Delete(3);
            resultado = controladorComponente.Get() as OkObjectResult;
            Assert.IsNotNull(resultado);
            listaModulos = resultado.Value as List<Componente>;
            Assert.IsNotNull(listaModulos);
            Assert.AreEqual(2, listaModulos.Count);
        }



        [TestMethod]
        public void TestObtenerTodosOrdenador()
        {
            var resultado = controladorOrdenador.Get() as OkObjectResult;
            Assert.IsNotNull(resultado);
            var ordenadores = resultado.Value as List<Ordenador>;
            Assert.IsNotNull(ordenadores);
            Assert.AreEqual(2, ordenadores.Count); // Cambia el número según tus datos de ejemplo
        }

        [TestMethod]
        public void TestObtenerOrdenadorExiste()
        {
            var resultado = controladorOrdenador.Get(1) as ObjectResult;
            Assert.IsNotNull(resultado);
            var ordenador = resultado.Value as Ordenador;
            Assert.IsNotNull(ordenador);
            // Aquí debes comprobar que los valores del ordenador coincidan con tus datos de ejemplo
            Assert.AreEqual(1, ordenador.Id);
            Assert.AreEqual(1000.0, ordenador.PrecioTotal);
            Assert.AreEqual(30, ordenador.CalorTotal);
            Assert.AreEqual(4, ordenador.CoresTotal);
            Assert.AreEqual(1024, ordenador.MegasTotal);
        }

        [TestMethod]
        public void TestObtenerOrdenadorNoExiste()
        {
            var resultado = controladorOrdenador.Get(6) as NotFoundResult;
            Assert.IsNotNull(resultado);
        }

        [TestMethod]
        public void TestOrdenadorCrear()
        {
            var resultado = controladorOrdenador.Get() as OkObjectResult;
            Assert.IsNotNull(resultado);
            var listaOrdenadores = resultado.Value as List<Ordenador>;
            Assert.IsNotNull(listaOrdenadores);
            var cantidadInicial = listaOrdenadores.Count;

            Ordenador ordenador = new()
            {
                PrecioTotal = 1200.0, // Ajusta los valores según tus necesidades
                CalorTotal = 35,
                CoresTotal = 8,
                MegasTotal = 2048
            };

            controladorOrdenador.Post(ordenador);
            resultado = controladorOrdenador.Get() as OkObjectResult;
            Assert.IsNotNull(resultado);
            listaOrdenadores = resultado.Value as List<Ordenador>;
            Assert.IsNotNull(listaOrdenadores);
            Assert.AreEqual(cantidadInicial + 1, listaOrdenadores.Count);
        }

        [TestMethod]
        public void TestOrdenadorBorrar()
        {
            var resultado = controladorOrdenador.Get() as OkObjectResult;
            Assert.IsNotNull(resultado);
            var listaOrdenadores = resultado.Value as List<Ordenador>;
            Assert.IsNotNull(listaOrdenadores);
            var cantidadInicial = listaOrdenadores.Count;

            controladorOrdenador.Delete(2); // Cambia el ID según tus datos de ejemplo
            resultado = controladorOrdenador.Get() as OkObjectResult;
            Assert.IsNotNull(resultado);
            listaOrdenadores = resultado.Value as List<Ordenador>;
            Assert.IsNotNull(listaOrdenadores);
            Assert.AreEqual(cantidadInicial - 1, listaOrdenadores.Count);
        }

    }
}