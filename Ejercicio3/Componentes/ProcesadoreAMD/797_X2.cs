using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio3.Interfaces;

namespace Ejercicio3.Componentes.ProcesadoreAMD
{
    public class _797_X2:IProcesable
    {
        readonly string NºSerie = "_797_X2"; readonly int precio = 178; readonly int cores = 29; readonly int grados = 30;
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
