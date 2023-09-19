using System;
using System.Collections.Generic;

namespace DataBaseFirst.Models;

public partial class OrdenadorComponente
{
    public int? Id { get; set; }

    public int? Ordenador { get; set; }

    public int? Componente { get; set; }

    public virtual Componente? ComponenteNavigation { get; set; }

    public virtual Ordenador? OrdenadorNavigation { get; set; }
}
