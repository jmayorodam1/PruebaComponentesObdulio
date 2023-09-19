using System.Linq;
using Microsoft.EntityFrameworkCore;
using PruebaComponentesObdulio.Models;

namespace PruebaComponentesObdulio.Repository
{
    public class FakeComponenteRepository : IComponenteRepository
    {
        readonly List<Componente> misComponentes = new();
        public FakeComponenteRepository()
        {
            misComponentes.Add(new Componente() {
                Id = 1,
                NumeroSerie = "789_XCS",
                Descripcion = "Procesador Intel i7",
                Calor = 10,
                Megas = 0,
                Cores = 9,
                Coste = 134.0,
                TipoComponente = 0
            });
            misComponentes.Add(new Componente()
            {
                Id = 2,
                NumeroSerie = "789_XCD",
                Descripcion = "Procesador Intel i7",
                Calor = 12,
                Megas = 0,
                Cores = 10,
                Coste = 138.0,
                TipoComponente = 0
            });
            misComponentes.Add(new Componente()
            {
                Id = 3,
                NumeroSerie = "789_XCD",
                Descripcion = "Procesador Intel i7",
                Calor = 12,
                Megas = 0,
                Cores = 10,
                Coste = 138.0,
                TipoComponente = 0
            });
        }

        public void Actualizar(Componente componente)
        {
            throw new NotImplementedException();
        }

      

        public void Agregar(Componente componente)
        {
            misComponentes.Add(componente);       
        }

     
        public void Eliminar(int id)
        {
            misComponentes.RemoveAt(id);
        }



        public Componente ObtenerPorId(int id)
        {
            return misComponentes.Find(c => c.Id == id);
        }

        public IEnumerable<Componente> ObtenerTodos()
        {
            return misComponentes;
        }


    }
}
