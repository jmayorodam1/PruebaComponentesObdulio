using System.Collections.Generic;
using System.Linq;
using TiendaOrdenadoresAPI.Models;

namespace TiendaOrdenadoresAPI.Repository
{
    public class FakeRepositorioOrdenadores : IRepositorio<Ordenador>
    {
        readonly List<Ordenador> misOrdenadores = new();

        public FakeRepositorioOrdenadores()
        {
            // Aquí puedes inicializar algunos ordenadores de ejemplo
            misOrdenadores.Add(new Ordenador()
            {
                Id = 1,
                PrecioTotal = 1000.0,
                CalorTotal = 30,
                CoresTotal = 4,
                MegasTotal = 1024
            });
            misOrdenadores.Add(new Ordenador()
            {
                Id = 2,
                PrecioTotal = 1500.0,
                CalorTotal = 40,
                CoresTotal = 8,
                MegasTotal = 2048
            });
        }

        public List<Ordenador> ObtenerTodos()
        {
            return misOrdenadores;
        }

        public Ordenador? Obtener(int Id)
        {
            return misOrdenadores.FirstOrDefault(x => x.Id == Id);
        }

        public void Añadir(Ordenador item)
        {
            misOrdenadores.Add(item);
        }

        public void Borrar(int id)
        {
            var ordenadorToRemove = misOrdenadores.FirstOrDefault(ord => ord.Id == id);
            if (ordenadorToRemove != null)
            {
                misOrdenadores.Remove(ordenadorToRemove);
            }
        }

        public void Actualizar(Ordenador ordenador)
        {
            var ordenadorAEditar = Obtener(ordenador.Id);
            if (ordenadorAEditar != null)
            {
                ordenadorAEditar.PrecioTotal = ordenador.PrecioTotal;
                ordenadorAEditar.CalorTotal = ordenador.CalorTotal;
                ordenadorAEditar.CoresTotal = ordenador.CoresTotal;
                ordenadorAEditar.MegasTotal = ordenador.MegasTotal;
            }
        }

        public int ObtenerUltimoId()
        {
            return misOrdenadores.Count > 0 ? misOrdenadores.Max(ord => ord.Id) : 0;
        }
    }
}
