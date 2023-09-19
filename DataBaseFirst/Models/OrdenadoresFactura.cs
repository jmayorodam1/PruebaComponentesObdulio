using System;
using System.Collections.Generic;

namespace DataBaseFirst.Models;

public partial class OrdenadoresFactura
{
    public int? Id { get; set; }

    public int? Ordenador { get; set; }

    public int? Factura { get; set; }

    public virtual Factura? FacturaNavigation { get; set; }

    public virtual Ordenador? OrdenadorNavigation { get; set; }
}
