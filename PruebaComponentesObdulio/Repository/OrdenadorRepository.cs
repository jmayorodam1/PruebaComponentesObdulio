using Microsoft.EntityFrameworkCore;
using PruebaComponentesObdulio.Data;
using PruebaComponentesObdulio.Models;
using System.Linq;

namespace PruebaComponentesObdulio.Repository
{
    public class OrdenadorRepository : IOrdenadorRepository
    {
        private readonly TiendaOrdenadoresContext _context;

        public OrdenadorRepository(TiendaOrdenadoresContext context)
        {
            _context = context;
        }

        public Ordenador ObtenerPorId(int id)
        {
            return _context.Set<Ordenador>().Find(id);
        }

        public IEnumerable<Ordenador> ObtenerTodos()
        {
            return _context.Set<Ordenador>().ToList();
        }

        public void Agregar(Ordenador ordenador)
        {
            _context.Set<Ordenador>().Add(ordenador);
            _context.SaveChanges();
        }

        public void Actualizar(Ordenador ordenador)
        {
            _context.Entry(ordenador).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var ordenador = _context.Set<Ordenador>().Find(id);
            if (ordenador != null)
            {
                _context.Set<Ordenador>().Remove(ordenador);
                _context.SaveChanges();
            }
        }
    }
}
