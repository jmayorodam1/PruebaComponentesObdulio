using PruebaComponentesObdulio.Models;
using System.Collections.Generic;


namespace PruebaComponentesObdulio.Repository
{
    public interface IComponenteRepository
    {
        Componente ObtenerPorId(int id);
        IEnumerable<Componente> ObtenerTodos();
        void Agregar(Componente componente);
        void Actualizar(Componente componente);
        void Eliminar(int id);
    }
}
