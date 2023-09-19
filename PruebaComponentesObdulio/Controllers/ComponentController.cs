using DataBaseFirst.Models;
using Microsoft.AspNetCore.Mvc;
using PruebaComponentesObdulio.Models;
using PruebaComponentesObdulio.Repository;
using System;
using Componente = PruebaComponentesObdulio.Models.Componente;
using Ordenador = PruebaComponentesObdulio.Models.Ordenador;

namespace PruebaComponentesObdulio.Controllers
{
    public class ComponentController : Controller
    {
        private readonly IComponenteRepository _componenteRepository;
        private readonly IOrdenadorRepository _ordenadorRepository;

        public ComponentController(IComponenteRepository componenteRepository  )
        {
            _componenteRepository = componenteRepository;
        }

        // GET: Component/Index
        public IActionResult Index()
        {
            var componentes = _componenteRepository.ObtenerTodos();
            return View("Index", componentes);
        }

        // GET: Component/Details/5
        public IActionResult Details(int id)
        {
            var componente = _componenteRepository.ObtenerPorId(id);
            if (componente == null)
            {
                return NotFound();
            }
            return View(componente);
        }

        // GET: Component/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Component/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Componente componente)
        {
            if (ModelState.IsValid)
            {
                _componenteRepository.Agregar(componente);
                return RedirectToAction("Index");
            }
            return View(componente);
        }

        // GET: Component/Edit/5
        public IActionResult Edit(int id)
        {
            var componente = _componenteRepository.ObtenerPorId(id);
            if (componente == null)
            {
                return NotFound();
            }
            return View(componente);
        }

        // POST: Component/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Componente componente)
        {
            if (id != componente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _componenteRepository.Actualizar(componente);
                }
                catch (Exception)
                {
                    return NotFound();
                }
                return RedirectToAction(nameof(Index));
            }
            return View(componente);
        }

        // GET: Component/Delete/5
        public IActionResult Delete(int id)
        {
            var componente = _componenteRepository.ObtenerPorId(id);
            if (componente == null)
            {
                return NotFound();
            }
            return View(componente);
        }

        // POST: Component/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _componenteRepository.Eliminar(id);
            return RedirectToAction(nameof(Index));
        }

        // CRUD operations for Ordenador

       
    }
}
