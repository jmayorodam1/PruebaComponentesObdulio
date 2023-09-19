using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Factura
    {
        List<Pedido> pedidos = new List<Pedido>();

        public void add(Pedido pedido)
        {
            pedidos.Add(pedido);
        }
        public double calcularPrecio()
        {

            double totalprecio = 0;

            foreach (Pedido pedido in pedidos)
            {
                totalprecio += pedido.calcularPrecio();
            }
            return totalprecio;
        }

        public int calcularGrados()
        {

            int totalgrados = 0;

            foreach (Pedido pedido in pedidos)
            {
                totalgrados += pedido.calcularGrados();
            }
            return totalgrados;
        }
    }
}
