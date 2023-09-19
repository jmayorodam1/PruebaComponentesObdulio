using DataBaseFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace DataBaseFirst.Repository
{
    public class RepositoryTienda: IRepositroy
    {
        private readonly TiendaOrdenadoresContext _context;

        public RepositoryTienda(TiendaOrdenadoresContext context)
        {
            _context = context;
        }

        public Componente ObtenerComponentePorId(int id)
        {
            return _context.Set<Componente>().Find(id);
        }

        public List<Componente> ObtenerTodosComponente()
        {
            return _context.Set<Componente>().ToList();
        }

        public void AgregarComponente(Componente componente)
        {
            _context.Set<Componente>().Add(componente);
            _context.SaveChanges();
        }

        public void ActualizarComponente(Componente componente)
        {
            _context.Entry(componente).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void EliminarComponente(int id)
        {
            var componente = _context.Set<Componente>().Find(id);
            if (componente != null)
            {
                _context.Set<Componente>().Remove(componente);
                _context.SaveChanges();
            }
        }
    



        public Ordenador ObtenerOrdenadorPorId(int id)
        {
            return _context.Set<Ordenador>().Find(id);
        }

        public List<Ordenador> ObtenerTodosOrdenadores()
        {
            return _context.Set<Ordenador>().ToList();
        }

        public void AgregarOrdenador(Ordenador ordenador)
        {
            _context.Set<Ordenador>().Add(ordenador);
            _context.SaveChanges();
        }

        public void ActualizarOrdenador(Ordenador ordenador)
        {
            _context.Entry(ordenador).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void EliminarOrdenador(int id)
        {
            var ordenador = _context.Set<Ordenador>().Find(id);
            if (ordenador != null)
            {
                _context.Set<Ordenador>().Remove(ordenador);
                _context.SaveChanges();
            }
        }
    
   

        public Factura ObtenerOrdenadoresFacturaPorId(int id)
        {
            return _context.Set<Factura>().Find(id);
        }

        public List<Factura> ObtenerTodosFacturas()
        {
            return _context.Set<Factura>().ToList();
        }

        public void AgregarFactura(Factura factura)
        {
            _context.Set<Factura>().Add(factura);
            _context.SaveChanges();
        }

        public void ActualizarFactura(Factura factura)
        {
            _context.Entry(factura).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void EliminarFactura(int id)
        {
            var factura = _context.Set<Factura>().Find(id);
            if (factura != null)
            {
                _context.Set<Factura>().Remove(factura);
                _context.SaveChanges();
            }
        }

        public OrdenadoresFactura ObtenerOrdenadorFacturaPorId(int id)
        {
            return _context.Set<OrdenadoresFactura>().Find(id);
        }

        public List<OrdenadoresFactura> ObtenerTodosOrdenadorFactura()
        {
            return _context.Set<OrdenadoresFactura>().ToList();
        }

        public void AgregarOrdenadoresFactura(OrdenadoresFactura factura)
        {
            _context.Set<OrdenadoresFactura>().Add(factura);
            _context.SaveChanges();
        }

        public void ActualizarOrdenadoresFactura(OrdenadoresFactura factura)
        {
            _context.Entry(factura).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void EliminarOrdenadoresFactura(int id)
        {
            var factura = _context.Set<OrdenadoresFactura>().Find(id);
            if (factura != null)
            {
                _context.Set<OrdenadoresFactura>().Remove(factura);
                _context.SaveChanges();
            }
        }
        public OrdenadorComponente ObtenerOrdenadorComponentePorId(int id)
        {
            return _context.Set<OrdenadorComponente>().Find(id);
        }

        public List<OrdenadorComponente> ObtenerTodosOrdenadorComponente()
        {
            return _context.Set<OrdenadorComponente>().ToList();
        }

        public void AgregarOrdenadorComponente(OrdenadorComponente factura)
        {
            _context.Set<OrdenadorComponente>().Add(factura);
            _context.SaveChanges();
        }

        public void ActualizarOrdenadorComponente(OrdenadorComponente factura)
        {
            _context.Entry(factura).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void EliminarOrdenadorComponente(int id)
        {
            var factura = _context.Set<OrdenadorComponente>().Find(id);
            if (factura != null)
            {
                _context.Set<OrdenadorComponente>().Remove(factura);
                _context.SaveChanges();
            }
        }

    
    }
}

