using System;
using System.Collections.Generic;

namespace DataBaseFirst.Models;

public partial class Ordenador
{
    public int Id { get; set; }

    public decimal? PrecioTotal { get; set; }

    public int? CoresTotal { get; set; }

    public int? MegasTotal { get; set; }

    public int? CalorTotal { get; set; }
}
