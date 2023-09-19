using PruebaComponentesObdulio.Models;
using System.Collections.Generic;
using System.Linq;

namespace PruebaComponentesObdulio.Repository
{
    public interface IOrdenadorRepository
    {
        Ordenador ObtenerPorId(int id);
        IEnumerable<Ordenador> ObtenerTodos();
        void Agregar(Ordenador ordenador);
        void Actualizar(Ordenador ordenador);
        void Eliminar(int id);
    }
}
