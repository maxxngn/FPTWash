using System;
using System.Collections.Generic;

namespace FPTWash.Models;

public partial class OrderItem
{
    public int Id { get; set; }

    public int? OrderId { get; set; }

    public string? Type { get; set; }

    public decimal? Weight { get; set; }

    public decimal? Price { get; set; }

    public virtual Order? Order { get; set; }
}
