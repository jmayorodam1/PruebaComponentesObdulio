using Microsoft.AspNetCore.Mvc;
using PruebaComponentesObdulio.Controllers;
using PruebaComponentesObdulio.Logging;
using PruebaComponentesObdulio.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaComponentesObdulio.Models;


namespace PruebaComponentesObdulio.Test
{   
    [TestClass]
    public class UnitTest
    {
        readonly ComponentController controlador = new(new FakeComponenteRepository());

        [TestMethod]
        public void PruebaCursosDetallesVistaEncontrado()
        {
            var result = controlador.Details(2) as ViewResult;
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.ViewData.Model);
            var componente = result.ViewData.Model as Componente;
            Assert.IsNotNull(componente);
            Assert.AreEqual("789_XCD", componente.NumeroSerie.ToString());
        }
        [TestMethod]
        public void PruebaCursosDetallesVistaNoEncontrado()
        {
            var result = controlador.Details(1) as ViewResult;
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.ViewData.Model);
            var componente = result.ViewData.Model as Componente;
            Assert.IsNotNull(componente);
            Assert.AreEqual("789_XCS",  componente.NumeroSerie);
        }
        [TestMethod]
        public void PruebaCursosIndexVistaOk()
        {
            var result = controlador.Index() as ViewResult;
            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.ViewName);
            Assert.IsNotNull(result.ViewData.Model);
            var componente = result.ViewData.Model as List<Componente>;
            Assert.IsNotNull(componente);
            Assert.AreEqual(3, componente.Count);
        }
    }
}
