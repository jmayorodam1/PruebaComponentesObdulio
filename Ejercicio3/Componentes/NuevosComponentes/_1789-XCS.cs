using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Componentes.NuevosComponentes
{
    public class _1789_XCS
    {
        readonly string NºSerie = "_1789_XCS"; readonly int precio = 138; readonly double almacenamiento = 10000; readonly int grados = 12;
        private int cantidad = 1;

        public int getCantidad()
        {
            return cantidad;
        }
        public double getAlmacenamiento()
        {
            return almacenamiento;
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
