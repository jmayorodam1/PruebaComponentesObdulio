using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio3.Interfaces;

namespace Ejercicio3.Componentes.ProcesadoreAMD
{
    public class _797_X:IProcesable
    {
        readonly string NºSerie = "_797_X";
        readonly int precio = 97;
        readonly int cores = 250;
        readonly int grados = 35;
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

