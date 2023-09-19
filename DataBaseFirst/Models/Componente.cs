using System;
using System.Collections.Generic;

namespace DataBaseFirst.Models;

public partial class Componente
{
    public int Id { get; set; }

    public decimal? Coste { get; set; }

    public string? NumeroSerie { get; set; }

    public int? Calor { get; set; }

    public int? Cores { get; set; }

    public string? Descripcion { get; set; }

    public int? Megas { get; set; }

    public int? TipoComponente { get; set; }
}
