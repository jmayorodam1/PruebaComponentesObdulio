﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio3.Interfaces;

namespace Ejercicio3.Componentes.DsicoExterno
{
    public class _1789_XCD : IGuardable
    {
        readonly string NºSerie = "_1789_XCD"; readonly int precio = 37; readonly double almacenamiento = 0.512; readonly int grados = 10;
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
