using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Interfaces
{
    public interface IMemorizable : Icomponente
    {
        double getAlmacenamiento();
    }
}
