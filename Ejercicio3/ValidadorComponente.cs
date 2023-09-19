using Ejercicio3.Interfaces;

namespace TiendaOrdenadores
{
    public class ValidadorComponente : IValidadorGuardable
    {
        public bool isValid(IGuardable miComponente)
        {

            return (miComponente != null && miComponente.getCalor != null && miComponente.getCalor() >= 0 &&
                 miComponente.getNSerie != null && miComponente.getNSerie() != ""
                && miComponente.getAlmacenamiento != null && miComponente.getAlmacenamiento() >= 0);
        }


    }
}