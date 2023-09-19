using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio3.Interfaces;

namespace Ejercicio3.Componentes.BancoMemoria
{
    public class _879FH_L:IMemorizable
    {
        readonly string NºSerie = "_879FH_L";
        readonly int precio = 125;
        readonly double almacenamiento = 1;
        readonly int grados = 15;
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
