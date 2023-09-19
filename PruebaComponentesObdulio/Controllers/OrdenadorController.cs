using Microsoft.AspNetCore.Mvc;
using PruebaComponentesObdulio.Models;
using PruebaComponentesObdulio.Repository;

namespace PruebaComponentesObdulio.Controllers
{
    public class OrdenadorController : Controller
    {
        private readonly IOrdenadorRepository _ordenadorRepository;

        public OrdenadorController( IOrdenadorRepository ordenadorRepository)
        {
            _ordenadorRepository = ordenadorRepository;
        }
        // GET: Component/ListOrdenadores
        public IActionResult ListOrdenadores()
        {
            var ordenadores = _ordenadorRepository.ObtenerTodos();
            return View("Index", ordenadores);
        }

        // GET: Component/DetailsOrdenador/5
        public IActionResult DetailsOrdenador(int id)
        {
            var ordenador = _ordenadorRepository.ObtenerPorId(id);
            if (ordenador == null)
            {
                return NotFound();
            }
            return View("Index", ordenador);
        }

        // GET: Component/CreateOrdenador
        public IActionResult CreateOrdenador()
        {
            return View();
        }

        // POST: Component/CreateOrdenador
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateOrdenador(Ordenador ordenador)
        {
            if (ModelState.IsValid)
            {
                _ordenadorRepository.Agregar(ordenador);
                return RedirectToAction("Ordenadores");
            }
            return View(ordenador);
        }

        // GET: Component/EditOrdenador/5
        public IActionResult EditOrdenador(int id)
        {
            var ordenador = _ordenadorRepository.ObtenerPorId(id);
            if (ordenador == null)
            {
                return NotFound();
            }
            return View(ordenador);
        }

        // POST: Component/EditOrdenador/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditOrdenador(int id, Ordenador ordenador)
        {
            if (id != ordenador.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _ordenadorRepository.Actualizar(ordenador);
                }
                catch (Exception)
                {
                    return NotFound();
                }
                return RedirectToAction("Ordenadores");
            }
            return View(ordenador);
        }

        // GET: Component/DeleteOrdenador/5
        public IActionResult DeleteOrdenador(int id)
        {
            var ordenador = _ordenadorRepository.ObtenerPorId(id);
            if (ordenador == null)
            {
                return NotFound();
            }
            return View(ordenador);
        }

        // POST: Component/DeleteOrdenador/5
        [HttpPost, ActionName("DeleteOrdenador")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteOrdenadorConfirmed(int id)
        {
            _ordenadorRepository.Eliminar(id);
            return RedirectToAction("Ordenadores");
        }
    }
}
