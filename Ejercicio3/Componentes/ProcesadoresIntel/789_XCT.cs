using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio3.Interfaces;

namespace Ejercicio3.Componentes.ProcesadoresIntel
{
    public class _789_XCT:IProcesable
    {
        readonly string NºSerie = "_789_XCT"; readonly int precio = 138; readonly int cores = 11; readonly int grados = 22;
        private int cantidad = 2;

        public int getCantidad()
        {
            return cantidad;
        }
        public int getCores()
        {
            return cores;
        }

        public int getCalor()
        {
            return grados;
        }

        public string getNSerie()
        {
            return NºSerie;
        }

        public int getPrecio()
        {
            return precio;
        }
        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }
    }
}
