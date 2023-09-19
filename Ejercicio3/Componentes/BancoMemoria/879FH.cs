using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Ejercicio3.Interfaces;

namespace Ejercicio3.Componentes.BancoMemoria
{
    public class _879FH:IMemorizable
    {
        readonly string NºSerie = "879FH";
        readonly int precio = 100;
        readonly double  almacenamiento = 0.512;
        readonly int grados = 10;
        private int cantidad = 2;

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
            return grados;        }

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
