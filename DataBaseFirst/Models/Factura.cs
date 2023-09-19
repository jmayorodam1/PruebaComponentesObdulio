using System;
using System.Collections.Generic;

namespace DataBaseFirst.Models;

public partial class Factura
{
    public int Id { get; set; }

    public decimal? PrecioTotal { get; set; }

    public decimal? CalorTotal { get; set; }
}
