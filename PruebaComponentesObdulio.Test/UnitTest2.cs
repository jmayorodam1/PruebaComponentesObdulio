using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PruebaComponentesObdulio.Controllers;
using PruebaComponentesObdulio.Models;
using PruebaComponentesObdulio.Repository;
using System.Collections.Generic;

namespace PruebaComponentesObdulio.Test
{
    [TestClass]
    public class OrdenadorControllerTests
    {
        private readonly OrdenadorController _controller;

        public OrdenadorControllerTests()
        {
            _controller = new OrdenadorController(new FakeOrdenadorRepository());
        }

        [TestMethod]
        public void Details_ReturnsViewWithOrdenadorFound()
        {
            // Arrange
            int ordenadorId = 2;

            // Act
            var result = _controller.DetailsOrdenador(ordenadorId) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.ViewData.Model);
            var ordenador = result.ViewData.Model as Ordenador;
            Assert.IsNotNull(ordenador);
            Assert.AreEqual(16384, ordenador.MegasTotal);
        }



        [TestMethod]
        public void Index_ReturnsViewWithListOfOrdenadores()
        {
            // Act
            var result = _controller.ListOrdenadores() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.ViewName);
            Assert.IsNotNull(result.ViewData.Model);
            var ordenadores = result.ViewData.Model as List<Ordenador>;
            Assert.IsNotNull(ordenadores);
            Assert.AreEqual(2, ordenadores.Count);
        }

   
    





    [TestMethod]
        public void Actualizar_ReturnsRedirectToAction()
        {
            // Arrange
            var ordenador = new Ordenador
            {
                Id = 1,
                PrecioTotal = 1000.0,
                CalorTotal = 50,
                CoresTotal = 8,
                MegasTotal = 8192
            };

            // Act
            var result = _controller.EditOrdenador(ordenador.Id, ordenador) as RedirectToActionResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Ordenadores", result.ActionName); // Redirecciona a la acción "Ordenadores".
        }

        [TestMethod]
        public void Eliminar_ReturnsRedirectToAction()
        {
            // Arrange
            var ordenadorId = 1;

            // Act
            var result = _controller.DeleteOrdenadorConfirmed(ordenadorId) as RedirectToActionResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Ordenadores", result.ActionName); // Redirecciona a la acción "Ordenadores".
        }
    }
}
