using System;
using System.Collections.Generic;
using System.Linq;
using PruebaComponentesObdulio.Models;
using PruebaComponentesObdulio.Repository;

namespace PruebaComponentesObdulio.Test
{
    public class FakeOrdenadorRepository : IOrdenadorRepository
    {
        private readonly List<Ordenador> _ordenadores;
        private int _nextId;

        public FakeOrdenadorRepository()
        {
            _ordenadores = new List<Ordenador>
            {
                new Ordenador
                {
                    Id = 1,
                    PrecioTotal = 1000.0,
                    CalorTotal = 50,
                    CoresTotal = 4,
                    MegasTotal = 8192
                },
                new Ordenador
                {
                    Id = 2,
                    PrecioTotal = 1500.0,
                    CalorTotal = 70,
                    CoresTotal = 8,
                    MegasTotal = 16384
                }
            };
            _nextId = 3;
        }

        public Ordenador ObtenerPorId(int id)
        {
            return _ordenadores.FirstOrDefault(o => o.Id == id);
        }

        public IEnumerable<Ordenador> ObtenerTodos()
        {
            return _ordenadores.ToList();
        }

        public void Agregar(Ordenador ordenador)
        {
            if (ordenador == null)
            {
                throw new ArgumentNullException(nameof(ordenador));
            }

            ordenador.Id = _nextId++;
            _ordenadores.Add(ordenador);
        }

        public void Actualizar(Ordenador ordenador)
        {
            if (ordenador == null)
            {
                throw new ArgumentNullException(nameof(ordenador));
            }

            var existingOrdenador = _ordenadores.FirstOrDefault(o => o.Id == ordenador.Id);
            if (existingOrdenador != null)
            {
                existingOrdenador.PrecioTotal = ordenador.PrecioTotal;
                existingOrdenador.CalorTotal = ordenador.CalorTotal;
                existingOrdenador.CoresTotal = ordenador.CoresTotal;
                existingOrdenador.MegasTotal = ordenador.MegasTotal;
            }
        }

        public void Eliminar(int id)
        {
            var ordenador = _ordenadores.FirstOrDefault(o => o.Id == id);
            if (ordenador != null)
            {
                _ordenadores.Remove(ordenador);
            }
        }
    }
}
