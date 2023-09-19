using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Pedido
    {
        List<Ordenador> pedido = new List<Ordenador>();

        public void add(Ordenador ordenador){
            pedido.Add(ordenador);
        }
        public double calcularPrecio() {

            double totalprecio = 0;

            foreach (Ordenador ordenador in pedido)
            {
                totalprecio += ordenador.precioTotal;
            }
            return totalprecio;
        }

        public int calcularGrados()
        {
            int totalgrados = 0;


            foreach (Ordenador ordenador in pedido)
            {
                totalgrados += ordenador.gradosTotal;
            }
            return totalgrados;
        }
    }
}
