using System.Collections.Generic;

namespace DataBaseFirst.Models
{
    public class ClasesViewModel
    {
        public List<Componente> Componentes { get; set; }
        public List<Factura> Facturas { get; set; }
        public List<Ordenador> Ordenadores { get; set; }
        public List<OrdenadorComponente> OrdenadorComponentes { get; set; }
        public List<OrdenadoresFactura> OrdenadoresFacturas { get; set; }
    }
}
