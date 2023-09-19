using System.Drawing;
using System.Reflection;

namespace TiendaOrdenadoresAPI.Models
{
    public class Componente
    {
        public int Id { get; set; }
        public double Coste { get; set; }
        public string NumeroSerie { get; set; }
        public int Calor { get; set; }
        public int Cores { get; set; }
        public string Descripcion { get; set; }
        public long Megas { get; set; }
        public int TipoComponente { get; set; }
    }
}
