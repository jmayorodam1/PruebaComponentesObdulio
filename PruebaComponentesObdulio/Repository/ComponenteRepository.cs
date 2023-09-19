using Microsoft.EntityFrameworkCore;
using PruebaComponentesObdulio.Data;
using PruebaComponentesObdulio.Models;
using System.Linq;


namespace PruebaComponentesObdulio.Repository
{
    public class ComponenteRepository : IComponenteRepository
    {
        private readonly TiendaOrdenadoresContext _context;

        public ComponenteRepository(TiendaOrdenadoresContext context)
        {
            _context = context;
        }

        public Componente ObtenerPorId(int id)
        {
            return _context.Set<Componente>().Find(id);
        }

        public IEnumerable<Componente> ObtenerTodos()
        {
            return _context.Set<Componente>().ToList();
        }

        public void Agregar(Componente componente)
        {
            _context.Set<Componente>().Add(componente);
            _context.SaveChanges();
        }

        public void Actualizar(Componente componente)
        {
            _context.Entry(componente).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var componente = _context.Set<Componente>().Find(id);
            if (componente != null)
            {
                _context.Set<Componente>().Remove(componente);
                _context.SaveChanges();
            }
        }
    }
}
