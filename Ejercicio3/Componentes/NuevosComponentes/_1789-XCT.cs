using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Componentes.NuevosComponentes
{
    public class _1789_XCT
    {
        readonly string NºSerie = "_1789_XCT"; readonly int precio = 140; readonly double almacenamiento = 11000; readonly int grados = 22;
        private int cantidad = 0;

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
