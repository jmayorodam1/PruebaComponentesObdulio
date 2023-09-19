using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Interfaces
{
    public interface Icomponente
    {

        string getNSerie();
        int getPrecio();
        int getCalor();

        int getCantidad();



        void setCantidad(int cantidad);
    }
}
