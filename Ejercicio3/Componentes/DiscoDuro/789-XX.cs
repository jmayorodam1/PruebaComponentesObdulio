using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio3.Interfaces;

namespace Ejercicio3.Componentes.DiscoDuro
{
    public class _789_XX:IGuardable
    {
        readonly string NºSerie = "_789_XX";
        readonly int precio = 50;
        readonly double almacenamiento = 500;
        readonly int grados = 10;
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
