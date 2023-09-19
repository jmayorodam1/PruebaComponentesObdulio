using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio3.Tipos;

namespace Ejercicio3.Interfaces
{
    public interface IOrdenadorInterface
    {
        IGuardable DameGuardable(TipoGuardable miembro);
        IMemorizable DameMemorizable(TipoMemorizable miembro);
        IProcesable DameProcesable(TipoProcesador miembro);
    }
}
