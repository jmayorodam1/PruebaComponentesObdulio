using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio3.Interfaces;

namespace Ejercicio3.Componentes.BancoMemoria
{
    public class _879FH_T:IMemorizable
    {
        readonly string NºSerie = "_879FH_T";
        readonly int precio = 150;
        readonly double almacenamiento = 2;
        readonly int grados = 24;
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
