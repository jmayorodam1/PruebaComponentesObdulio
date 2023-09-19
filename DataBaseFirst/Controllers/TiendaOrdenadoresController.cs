using Microsoft.AspNetCore.Mvc;
using DataBaseFirst.Models;
using DataBaseFirst.Repository;

namespace DataBaseFirst.Controllers
{
    public class TiendaOrdenadoresController : Controller
    {
        private readonly IRepositroy _componenteRepository;


        public TiendaOrdenadoresController(IRepositroy componenteRepository)
        {
            _componenteRepository = componenteRepository;

        }

        public IActionResult Index()
        {
            var viewModel = new ClasesViewModel
            {
                Componentes = _componenteRepository.ObtenerTodosComponente(),
                Facturas = _componenteRepository.ObtenerTodosFacturas(),
                Ordenadores = _componenteRepository.ObtenerTodosOrdenadores(),
                OrdenadorComponentes = _componenteRepository.ObtenerTodosOrdenadorComponente(),
                OrdenadoresFacturas = _componenteRepository.ObtenerTodosOrdenadorFactura()
            };

            return View(viewModel);
        }

        // GET: HomeController
        public IActionResult IndexComponentes()
        {
            var componentes = _componenteRepository.ObtenerTodosComponente();
            return View("Index", componentes);
        }

        // GET: HomeController/Details/5

        public IActionResult DetailsComponentes(int id)
        {
            var componente = _componenteRepository.ObtenerComponentePorId(id);
            if (componente == null)
            {
                return NotFound();
            }
            return View(componente);
        }
        // GET: HomeController/Create

        public IActionResult Create()
        {
            return View();
        }
        // POST: HomeController/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateComponentes(Componente componente)
        {
            if (ModelState.IsValid)
            {
                _componenteRepository.AgregarComponente(componente);
                return RedirectToAction("Index");
            }
            return View(componente);
        }


        // GET: HomeController/Edit/5

        [HttpPost]
        public IActionResult EditComponentes(int id, Componente componente)
        {
            if (id != componente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _componenteRepository.ActualizarComponente(componente);
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
        [HttpGet]
        public IActionResult DeleteComponentes(int id)
        {
            var componente = _componenteRepository.ObtenerComponentePorId(id);
            if (componente == null)
            {
                return NotFound();
            }
            return View(componente);
        }

        // POST: Component/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmedComponentes(int id)
        {
            _componenteRepository.EliminarComponente(id);
            return RedirectToAction(nameof(Index));
        }

        // GET: HomeController
        public IActionResult IndexFacturas()
        {
            var componentes = _componenteRepository.ObtenerTodosFacturas();
            return View("Index", componentes);
        }

        // GET: HomeController/Details/5

        public IActionResult DetailsFacturas(int id)
        {
            var componente = _componenteRepository.ObtenerOrdenadoresFacturaPorId(id);
            if (componente == null)
            {
                return NotFound();
            }
            return View(componente);
        }
        // GET: HomeController/Create

    
        // POST: HomeController/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateFactura(Factura componente)
        {
            if (ModelState.IsValid)
            {
                _componenteRepository.AgregarFactura(componente);
                return RedirectToAction("Index");
            }
            return View(componente);
        }


        // GET: HomeController/Edit/5

        [HttpPost]
        public IActionResult EditFactura(int id, Factura componente)
        {
            if (id != componente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _componenteRepository.ActualizarFactura(componente);
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
        [HttpGet]
        public IActionResult DeleteFacturas(int id)
        {
            var componente = _componenteRepository.ObtenerOrdenadoresFacturaPorId(id);
            if (componente == null)
            {
                return NotFound();
            }
            return View(componente);
        }

        // POST: Component/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmedFactura(int id)
        {
            _componenteRepository.EliminarFactura(id);
            return RedirectToAction(nameof(Index));
        }

        // GET: HomeController
        public IActionResult IndexOrdenadoresFacturas()
        {
            var componentes = _componenteRepository.ObtenerTodosOrdenadorFactura();
            return View("Index", componentes);
        }

        // GET: HomeController/Details/5

        public IActionResult DetailsOrdenadorFacturas(int id)
        {
            var componente = _componenteRepository.ObtenerOrdenadorFacturaPorId(id);
            if (componente == null)
            {
                return NotFound();
            }
            return View(componente);
        }
        // GET: HomeController/Create


        // POST: HomeController/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateOrdenadorFactura(OrdenadoresFactura componente)
        {
            if (ModelState.IsValid)
            {
                _componenteRepository.AgregarOrdenadoresFactura(componente);
                return RedirectToAction("Index");
            }
            return View(componente);
        }


        // GET: HomeController/Edit/5

        [HttpPost]
        public IActionResult EditOrdenadorFactura(int id, OrdenadoresFactura componente)
        {
            if (id != componente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _componenteRepository.ActualizarOrdenadoresFactura(componente);
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
        [HttpGet]
        public IActionResult DeleteOrdenadorFacturas(int id)
        {
            var componente = _componenteRepository.ObtenerOrdenadoresFacturaPorId(id);
            if (componente == null)
            {
                return NotFound();
            }
            return View(componente);
        }

        // POST: Component/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmedOrdenadorFactura(int id)
        {
            _componenteRepository.EliminarOrdenadoresFactura(id);
            return RedirectToAction(nameof(Index));
        }

        // GET: HomeController
        public IActionResult IndexOrdenadorComponente()
        {
            var componentes = _componenteRepository.ObtenerTodosOrdenadorComponente();
            return View("Index", componentes);
        }

        // GET: HomeController/Details/5

        public IActionResult DetailsOrdenadorComponente(int id)
        {
            var componente = _componenteRepository.ObtenerOrdenadorComponentePorId(id);
            if (componente == null)
            {
                return NotFound();
            }
            return View(componente);
        }
        // GET: HomeController/Create


        // POST: HomeController/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateOrdenadorComponente(OrdenadorComponente componente)
        {
            if (ModelState.IsValid)
            {
                _componenteRepository.AgregarOrdenadorComponente(componente);
                return RedirectToAction("Index");
            }
            return View(componente);
        }


        // GET: HomeController/Edit/5

        [HttpPost]
        public IActionResult EditOrdenadorComponente(int id, OrdenadorComponente componente)
        {
            if (id != componente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _componenteRepository.ActualizarOrdenadorComponente(componente);
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
        [HttpGet]
        public IActionResult DeleteOrdenadorComponente(int id)
        {
            var componente = _componenteRepository.ObtenerOrdenadorComponentePorId(id);
            if (componente == null)
            {
                return NotFound();
            }
            return View(componente);
        }

        // POST: Component/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmedOrdenadorComponente(int id)
        {
            _componenteRepository.EliminarFactura(id);
            return RedirectToAction(nameof(Index));
        }


      
    }
}
