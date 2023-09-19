using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio3.Interfaces;

namespace Ejercicio3.Componentes.ProcesadoresIntel
{
    public class _789_XCD:IProcesable
    {
        readonly string NºSerie = "_789_XCD";
        readonly int precio = 134;
        readonly int cores = 9;
        readonly int grados = 10;
        private int cantidad = 1;

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
